using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Data.SqlClient;

namespace AnimalShelter.Model
{
    /// <summary>
    /// 
    /// </summary>
 
    
    public class DAL
     {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newrow"></param>

           public void CREATE(Model newrow)
          {

              NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Database=Assignment2.Proj2; IntegratedSecurity=true;");
              // NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=astronauta;Database=Assignment2.Proj2;");
               conn.Open();

               NpgsqlCommand command = new NpgsqlCommand("INSERT INTO animals(breed,weight1,age) VALUES (:breed,:weight1,:age) ", conn);
               command.Parameters.Add(new NpgsqlParameter("breed", NpgsqlDbType.Text));
               command.Parameters.Add(new NpgsqlParameter("weight1", NpgsqlDbType.Double));
               command.Parameters.Add(new NpgsqlParameter("age", NpgsqlDbType.Double));
               command.Prepare();
              
             

               command.Parameters[0].Value = newrow.breed;
               command.Parameters[1].Value = newrow.weight;
               command.Parameters[2].Value = newrow.age;

               command.ExecuteNonQuery();

                       
            
          }

         
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newrow"></param>

          public void UPDATE (Model newrow)
           {
               NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Database=Assignment2.Proj2; IntegratedSecurity=true;");
              //NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=astronauta;Database=Assignment2.Proj2;");
               conn.Open();

               
               NpgsqlCommand command = new NpgsqlCommand("UPDATE animals SET  breed = :breed, weight1 = :weight1, age = :age WHERE animal_id = :animal_id  ", conn);        
               command.Parameters.Add(new NpgsqlParameter("breed", NpgsqlDbType.Text));
               command.Parameters.Add(new NpgsqlParameter("weight1", NpgsqlDbType.Double));
               command.Parameters.Add(new NpgsqlParameter("age", NpgsqlDbType.Double));
               command.Parameters.Add(new NpgsqlParameter("animal_id", NpgsqlDbType.Integer));
               command.Prepare();
              

               command.Parameters[0].Value = newrow.breed;
               command.Parameters[1].Value = newrow.weight;
               command.Parameters[2].Value = newrow.age;
               command.Parameters[3].Value = newrow.id;

               command.ExecuteNonQuery();

           }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="newrow"></param>
          public void DELETE(Model newrow)
          {
              NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Database=Assignment2.Proj2; IntegratedSecurity=true;");
              //NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=astronauta;Database=Assignment2.Proj2;");
              conn.Open();

             
              NpgsqlCommand command = new NpgsqlCommand("DELETE FROM animals WHERE animal_id = :animal_id  ", conn);
             
              command.Parameters.Add(new NpgsqlParameter("animal_id", NpgsqlDbType.Integer));
              command.Prepare();

              command.Parameters[0].Value = newrow.id;
        
              command.ExecuteNonQuery();

          }

          /*
          public static List<Model> Read()
          {
              List<Model> results = new List<Model>();


              NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=astronauta;Database=Assignment2.Proj2;");


              try
              {
                  conn.Open();

                  NpgsqlCommand cmd = new NpgsqlCommand("SELECT *FROM \"animals\"", conn);
                  NpgsqlDataReader dr = cmd.ExecuteReader();

                 
                  
                  while (dr.Read())
                  {
                      Model temp = new Model();

                      temp.id = ((int)dr[0]);
                      temp.breed = ((string)dr[1]);
                      temp.weight = ((double)dr[2]);
                      temp.age = (double)dr[3];

                      results.Add(temp);
                      

                  } 
              }
              finally
              {
                  conn.Close();
              }
              return results;
          }





         */

     }
}