using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neyðarsimi
{
    class trial : Global
    {
        #region "Class"
        dbConnection clsDatabase = new dbConnection();
        #endregion

        #region "VARIABLES"
        public int numer;
        public string dagur = "arniarni"; 
        #endregion

        #region "PROPERTIES"
        public void setDagur(string dagur)
        {
            this.dagur = dagur;
        }

        public void setNumer(int numer)
        {
            this.numer = numer;
        }

        public string getDagur()
        {
            return dagur;
        }

        public int getNumer()
        {
            return numer;
        }
        #endregion

        #region "Functions"
        public void haekkunDagur()
        {
            numer = 5;
        }

        public void skraNumerDagur()
        {
            string sqlString = "INSERT INTO tblTrial(haekkun) VALUES('" + numer + "')" ;
            clsDatabase.ExcuteQuery(sqlString); 
        }

        public void leyfisdagur()
        {
            string sqlString = "SELECT haekkun FROM tblTrial;" ;
            clsDatabase.GetRecord(sqlString);

            while (reader.Read())
            {
                
            }
            reader.Close();
        }
        
        #endregion 
    }
}
