using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;
using System.Web.Configuration;
using System.Web.Services;
using System.Data.SqlClient;

namespace AnimalShelter.Model
{
     public partial class WebForm1 : System.Web.UI.Page
     {
         /// <summary>
         /// 
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         protected void Page_Load(object sender, EventArgs e)
         {
             NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Database=Assignment2.Proj2; IntegratedSecurity=true;");
             //NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=astronauta;Database=Assignment2.Proj2;");
             NpgsqlCommand cmd = new NpgsqlCommand("SELECT *FROM animals", conn);
             conn.Open();


             GridView1.DataSource = cmd.ExecuteReader();
             GridView1.DataBind();
         }
        
         /// <summary>
         /// 
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
         
         protected void Button_Insert(object sender, EventArgs e)
           {

                DAL db = new DAL();
                var item = new Model();

                item.breed = txtBreed.Text;
                item.weight = Convert.ToDouble(weight.Text);
                item.age = Convert.ToDouble(age.Text);
                db.CREATE(item);
                    


           }

         /// <summary>
         /// 
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
           protected void Button_Update(object sender, EventArgs e)
           {

               DAL db = new DAL(); 
               var item = new Model();

               item.id =Convert.ToInt16(textID.Text);
               item.breed = txtBreed.Text;
               item.weight = Convert.ToDouble(weight.Text);
               item.age = Convert.ToDouble(age.Text);
               db.UPDATE(item);



          }

         /// <summary>
         /// 
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
          protected void Button_Delete(object sender, EventArgs e)
          {

              DAL db = new DAL();
              var item = new Model();

              item.id = Convert.ToInt16(textID.Text);
              db.DELETE(item);
          
          }

    
                 

     }
}