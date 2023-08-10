using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class Filters
    {
        public IEnumerable<ProductAttributeDetail> GetFilteredProducts(List<FilterCriteria> filters, int subcategoryId)
        {
            string dynamicSQL = GenerateDynamicSQL(filters, subcategoryId);

            using (SqlConnection connection = new SqlConnection("Data source=DESKTOP-RQ3BRI1\\SQLEXPRESS;initial catalog=master;persist security info=True;user id=sa;password=000;Connect Timeout=30;MultipleActiveResultSets=true"))
            {
                using (SqlCommand cmd = new SqlCommand(dynamicSQL, connection))
                {
                    int counter = 1;

                    foreach (var filter in filters)
                    {
                        cmd.Parameters.AddWithValue($"@AttributeID{counter}", filter.AttributeId);
                        cmd.Parameters.AddWithValue($"@MinValue{counter}", filter.MinValue);
                        cmd.Parameters.AddWithValue($"@MaxValue{counter}", filter.MaxValue);
                        counter++;
                    }

                    cmd.Parameters.AddWithValue("@SubcategoryID", subcategoryId);
                    cmd.Parameters.AddWithValue("@NumberOfAttributesFiltered", filters.Count);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable result = new DataTable();
                    adapter.Fill(result);


                    List<ProductAttributeDetail> productAttributes = result.AsEnumerable()
                    .Select(row => new ProductAttributeDetail
                    {
                    ProductsID = Convert.ToInt32(row["ProductsID"]),
                    Product_Name = row["Product_Name"].ToString(),
                    Description = row["Description"].ToString(),
                    CategoriesID = Convert.ToInt32(row["CategoriesID"]),
                    AttributesID = Convert.ToInt32(row["AttributesID"]),
                    Attribute_Name = row["Attribute_Name"].ToString(),
                    Attribute_ValuesID = Convert.ToInt32(row["Attribute_ValuesID"]),
                    Attribute_Value = row["Attribute_Value"].ToString(),
                    Image_URL = row["Image_URL"].ToString()
                    
            })
            .ToList();

                    return productAttributes;
                }
            }
        }



        public string GenerateDynamicSQL(List<FilterCriteria> filters, int subcategoryId)
        {
            var whereClauses = new List<string>();
            var joinClauses = new List<string>();

            int counter = 1;

            foreach (var filter in filters)
            {
                whereClauses.Add($"pa{counter}.AttributesID = @AttributeID{counter} AND pa{counter}.Min_Continuous_Attribute_Value >= @MinValue{counter} AND pa{counter}.Max_Continuous_Attribute_Value <= @MaxValue{counter}");
                joinClauses.Add($"INNER JOIN dbo.Product_Attributes pa{counter} ON p.ProductsID = pa{counter}.ProductsID");

                counter++;
            }

            var whereSection = string.Join(" AND ", whereClauses);
            var joinSection = string.Join(" ", joinClauses);

            var query = $@"
        WITH FilteredProducts AS (
            SELECT 
                p.ProductsID 
            FROM 
                dbo.Products p
            {joinSection}
            WHERE 
                {whereSection}
            AND
                p.SubcategoriesID = @SubcategoryID
            GROUP BY p.ProductsID
            HAVING COUNT(DISTINCT pa1.AttributesID) = @NumberOfAttributesFiltered
        )

        SELECT DISTINCT 
            fp.ProductsID, 
            p.Product_Name, 
            p.Description, 
			P.CategoriesID,
			p.Image_URL,
            a.AttributesID, 
            a.Attribute_Name,
            av.Attribute_Value,
			av.Attribute_ValuesID
        FROM 
            FilteredProducts fp
        INNER JOIN 
            dbo.Products p ON fp.ProductsID = p.ProductsID
        INNER JOIN 
            dbo.Product_Attributes pa ON p.ProductsID = pa.ProductsID
        INNER JOIN 
            dbo.Attributes a ON pa.AttributesID = a.AttributesID
        LEFT JOIN 
            dbo.Attribute_Values av ON pa.Discrete_Attribute_Value_ID = av.Attribute_ValuesID";

            return query;
        }

    }


}
