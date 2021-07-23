using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Web;

namespace CRM.Data
{
    public class Profile : DataObject
    {
        private int userId
        {
            get;
            set;
        }
        private string fname
        {
            get;
            set;
        }

        private string lname
        {
            get;
            set;
        }

        private long phoneNo
        {
            get;
            set;
        }
        private string email
        {
            get;
            set;
        }
        private int addressId
        {
            get;
            set;
        }
        public int UserId
        {
            get => userId;
            set => userId = value;
        }
        public string FName
        {
            get => fname;
                set => fname = value;
        }
        public string LName
        {
            get => lname;
            set => lname = value;
        }
        public long PhoneNo
        {
            get => phoneNo;
            set => phoneNo = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public int AddressId
        {
            get => addressId;
            set => addressId = value;
        }
        void Initilize()
        {
            fname = "";
            lname = "";
            email = "";
            
        }

        public Profile()
        {
            Initilize();
        }

        public Profile(int id)
        {
            Initilize();
            GetUserProfile(id);
     
        }

        //public Profile (int id)
        //{
        //    UpdateUserprofile(id);
        //}


        public void GetUserProfile(int id)
        {
            SqlConnection conn = Trans == null ? new SqlConnection(ConnStr) : Trans.Connection;
            SqlCommand cmd = new SqlCommand("GetUserProfile", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter _userId = cmd.Parameters.Add("@UserProfileId", SqlDbType.Int);
            _userId.Direction = ParameterDirection.Input;
            SqlParameter _fname = cmd.Parameters.Add("@Fname", SqlDbType.NVarChar, 100);
            _fname.Direction = ParameterDirection.Output;
            SqlParameter _lname = cmd.Parameters.Add("@Lname", SqlDbType.NVarChar, 100);
            _lname.Direction = ParameterDirection.Output;
            SqlParameter _phoneNo = cmd.Parameters.Add("@phoneNo", SqlDbType.Int, 100);
            _phoneNo.Direction = ParameterDirection.Output;
            SqlParameter _email = cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100);
            _email.Direction = ParameterDirection.Output;
            SqlParameter _addressId = cmd.Parameters.Add("@addressId", SqlDbType.Int, 100);
            _addressId.Direction = ParameterDirection.Output;


            try
            {
                if (Trans == null || (Trans.Connection.State & ConnectionState.Open) == 0)
                    conn.Open();
                cmd.ExecuteNonQuery();
                this.userId = Convert.ToInt32(_userId);
                this.fname = Convert.IsDBNull(_fname) ? "" : _fname.Value.ToString();
                this.lname = Convert.IsDBNull(_lname) ? "" : _lname.Value.ToString();
                this.phoneNo = Convert.ToInt32(_phoneNo);
                this.email = Convert.IsDBNull(_email) ? "" : _email.Value.ToString();
                this.addressId = Convert.ToInt32(_addressId); //ahiya trigger mukvi padse
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateUserprofile(int id)
        {
            SqlConnection conn = Trans == null ? new SqlConnection(ConnStr) : Trans.Connection;
            SqlCommand cmd = new SqlCommand("UpdateUserProfile", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter _fname = cmd.Parameters.Add("@Fname", SqlDbType.NVarChar, 100);
            _fname.Direction = ParameterDirection.Output;
            SqlParameter _lname = cmd.Parameters.Add("@Lname", SqlDbType.NVarChar, 100);
            _lname.Direction = ParameterDirection.Output;
            SqlParameter _phoneNo = cmd.Parameters.Add("@phoneNo", SqlDbType.Int, 100);
            _phoneNo.Direction = ParameterDirection.Output;
            SqlParameter _email = cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100);
            _email.Direction = ParameterDirection.Output;
            SqlParameter _addressId = cmd.Parameters.Add("@addressId", SqlDbType.Int, 100);
            _addressId.Direction = ParameterDirection.Output;


            try
            {
                if (Trans == null || (Trans.Connection.State & ConnectionState.Open) == 0)
                    conn.Open();
                cmd.ExecuteNonQuery();

                this.fname = Convert.IsDBNull(_fname) ? "" : _fname.Value.ToString();
                this.lname = Convert.IsDBNull(_lname) ? "" : _lname.Value.ToString();
                this.phoneNo = Convert.ToInt32(_phoneNo);
                this.email = Convert.IsDBNull(_email) ? "" : _email.Value.ToString();
                this.addressId = Convert.ToInt32(_addressId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        public void DeleteUserProfile(int id)
        {
            SqlConnection conn = Trans == null ? new SqlConnection(ConnStr) : Trans.Connection;
            SqlCommand cmd = new SqlCommand("DeleteUserProfile", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter _fname = cmd.Parameters.Add("@Fname", SqlDbType.NVarChar, 100);
            _fname.Direction = ParameterDirection.Output;
            SqlParameter _lname = cmd.Parameters.Add("@Lname", SqlDbType.NVarChar, 100);
            _lname.Direction = ParameterDirection.Output;
            SqlParameter _phoneNo = cmd.Parameters.Add("@phoneNo", SqlDbType.Int, 100);
            _phoneNo.Direction = ParameterDirection.Output;
            SqlParameter _email = cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100);
            _email.Direction = ParameterDirection.Output;
            SqlParameter _addressId = cmd.Parameters.Add("@addressId", SqlDbType.Int, 100);
            _addressId.Direction = ParameterDirection.Output;


            try
            {
                if (Trans == null || (Trans.Connection.State & ConnectionState.Open) == 0)
                    conn.Open();
                cmd.ExecuteNonQuery();

                this.fname = Convert.IsDBNull(_fname) ? "" : _fname.Value.ToString();
                this.lname = Convert.IsDBNull(_lname) ? "" : _lname.Value.ToString();
                this.phoneNo = Convert.ToInt32(_phoneNo);
                this.email = Convert.IsDBNull(_email) ? "" : _email.Value.ToString();
                this.addressId = Convert.ToInt32(_addressId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void CreateUserProfile(int id)
        {
            SqlConnection conn = Trans == null ? new SqlConnection(ConnStr) : Trans.Connection;
            SqlCommand cmd = new SqlCommand("CreateUserProfile", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter _fname = cmd.Parameters.Add("@Fname", SqlDbType.NVarChar, 100);
            _fname.Direction = ParameterDirection.Output;
            SqlParameter _lname = cmd.Parameters.Add("@Lname", SqlDbType.NVarChar, 100);
            _lname.Direction = ParameterDirection.Output;
            SqlParameter _phoneNo = cmd.Parameters.Add("@phoneNo", SqlDbType.Int, 100);
            _phoneNo.Direction = ParameterDirection.Output;
            SqlParameter _email = cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100);
            _email.Direction = ParameterDirection.Output;
            SqlParameter _addressId = cmd.Parameters.Add("@addressId", SqlDbType.Int, 100);
            _addressId.Direction = ParameterDirection.Output;


            try
            {
                if (Trans == null || (Trans.Connection.State & ConnectionState.Open) == 0)
                    conn.Open();
                cmd.ExecuteNonQuery();

                this.fname = Convert.IsDBNull(_fname) ? "" : _fname.Value.ToString();
                this.lname = Convert.IsDBNull(_lname) ? "" : _lname.Value.ToString();
                this.phoneNo = Convert.ToInt32(_phoneNo);
                this.email = Convert.IsDBNull(_email) ? "" : _email.Value.ToString();
                this.addressId = Convert.ToInt32(_addressId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Profile> List()
        {
            List<Profile> profiles = new List<Profile>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Select * From Profile order by UserId");

            SqlConnection conn = new SqlConnection(ConnStr);
            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

            try
            {
               
                conn.Open();

                SqlDataAdapter sa = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                sa.Fill(ds);

                foreach (DataRow dataRow in ds.Tables[0].Rows)
                {
                    Profile profile = new Profile 
                    {
                        fname = dataRow["FName"].ToString(),
                        lname = dataRow["LName"].ToString(),
                        userId = Convert.ToInt32(dataRow["UserId"].ToString()),
                        phoneNo = Convert.ToInt64(dataRow["PhoneNo"].ToString()),
                        email = dataRow["Email"].ToString(),
                        addressId = Convert.ToInt32(dataRow["AddressId"].ToString())
                    };

                    profiles.Add(profile);
                } 

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return profiles;
        }
    }
}