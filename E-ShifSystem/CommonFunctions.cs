using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

using System.Text.RegularExpressions;


namespace E_ShifSystem
{
    internal class CommonFunctions
    {
        //Login Details
        public static loginDetails logedUserInfo = null;


        //SQL Connection String 
        public static SqlConnection con = new SqlConnection(@"Data Source=GISH;Initial Catalog=E_ShiftSystem;Integrated Security=True");


        // Load Data into DataGridView
        internal static void DataTableLoadFun(string _sql, DataGridView _loadTable)
        {
            SqlDataAdapter da = new SqlDataAdapter(_sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            _loadTable.DataSource = dt;
        }


        //Create a Data table with the help of query and returing the datatable 
        internal static DataTable tableFun(string _sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(_sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Insert Function
        internal static void insertFun(string _sql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(_sql, con);
                int count = cmd.ExecuteNonQuery();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Data Inserted Successfully", "Successfully Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Inserting \n " + ex.Message ,"Error Occurred", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        // Update Function 
        internal static void updateFun(string _sql)
        {
            try
            {
                if (MessageBox.Show("Want to update ? ", "Update Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(_sql, con);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Data Update Successfully", "Successfully Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops!! Error in updating \n " + ex.Message, "Error Occurred", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        internal static void updateFunWithoutMsgBox(string _sql)
        {
            try
            {
                if (MessageBox.Show("Want to update ? ", "Update Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(_sql, con);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops!! Error in updating \n " + ex.Message, "Error Occurred", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        internal static void updateFunNoMsgBox(string _sql)
        {
            try
            {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(_sql, con);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops!! Error in updating \n " + ex.Message, "Error Occurred", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        // Delete Function
        internal static void deleteFun(string _sql)
        {
            try
            {
                if (MessageBox.Show("Want to delete ? ", "Delete Confimation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(_sql, con);
                    int count = cmd.ExecuteNonQuery();
                    con.Close();

                    if (count > 0)
                    {
                        MessageBox.Show("Data Deleted Successfully", "Successfully Deleted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops!! Error in deleting \n " + ex.Message, "Error Occurred", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        internal static int insertAndReturnID(string _sql)
        {
            int newCusID = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(_sql, con);
                newCusID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Inserting and Returing the ID \n " + ex.Message, "Error Occurred", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return newCusID;
        }

        
/*
        internal static void updateWithoutMsgBox(string _sql)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(_sql, con);
                int count = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }*/


        

        public static Boolean validate(List<TextBox> myBoxList)
        {
            Boolean myReturn = true;

            //Loop used to check all the Text box whether they are empty or not 
            foreach (TextBox myBox in myBoxList)
            {
                if (myBox.Text == "")
                {
                    myReturn = false;
                    // Text Box Colour Change 
                    myBox.BackColor = Color.Red;
                }
                else
                {
                    // change back colour text box colour 
                    myBox.BackColor = Color.White;
                }
            }
            return myReturn;
        }

        public static Boolean validate(List<ComboBox> myBoxList)
        {
            Boolean myReturn = true;

            //Loop used to check all the combo box whether they are empty or not 
            foreach (ComboBox myBox in myBoxList)
            {
                if (myBox.Text == "")
                {
                    myReturn = false;
                    // Text Box Colour Change 
                    myBox.BackColor = Color.Red;
                }
                else
                {
                    // change back colour text box colour 
                    myBox.BackColor = Color.White;
                }
            }

            return myReturn;
        }


        //>>>>>>>>>>>>>>>--------------------- C O M B O B O X --------------------->>>>>>>>>>>>>>>




        internal static void DataComboBox(string _sql, ComboBox _box, string _DisplayColumnName, string _ValueColumnName)
        {
            _box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _box.AutoCompleteSource = AutoCompleteSource.ListItems;

            string sql = _sql;
            SqlDataAdapter da = new SqlDataAdapter(sql, CommonFunctions.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            _box.DisplayMember = _DisplayColumnName;
            _box.ValueMember = _ValueColumnName;
            _box.DataSource = dt;


        }




        //------------------------->>>> Form Load <<<<------------------------------------//

        public static void loadFormFun(Form _loadForm, Panel _loadPanel)
        {
            _loadPanel.Controls.Clear();
            _loadForm.TopLevel = false;
            _loadPanel.Controls.Add(_loadForm);
            _loadForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            _loadForm.Dock = DockStyle.Fill;
            _loadForm.Show();

        }


        public static Boolean checkComoboBoxData(List<ComboBox> myBoxList)
        {
            Boolean myReturn = true;
            foreach (ComboBox myBox in myBoxList)
            {
                if (myBox.SelectedValue == null)
                {
                    // Text Box Colour Change 
                    myBox.BackColor = Color.Red;
                    myReturn = false;
                }
                else
                {
                    // change back colour text box colour 
                    myBox.BackColor = Color.White;
                    myReturn = true;
                }

            }
            return myReturn;
        }


        public static void resetAllTextBoxes(List<TextBox> myBoxList)
        {
            
            //Foreach Loop
            foreach (TextBox myBox in myBoxList)
            {
                myBox.ResetText();
            }
        }
        public static void resetAllTextBoxes(List<ComboBox> myBoxList)
        {

            //Foreach Loop
            foreach (ComboBox myBox in myBoxList)
            {
                myBox.ResetText();
            }
        }



        public static void allowOnlyNumberChar(object _sender,KeyPressEventArgs _e)
        {
            if (!char.IsControl(_e.KeyChar) && !char.IsDigit(_e.KeyChar) &&
            (_e.KeyChar != '.'))
            {
                _e.Handled = true;
            }

            // only allow one decimal point
            if ((_e.KeyChar == '.') && ((_sender as TextBox).Text.IndexOf('.') > -1))
            {
                _e.Handled = true;
            }
        }




        public static int getLastInsertedIDinColumn(string _columnName)
        {
            int lastID = 0;
            try
            {
                con.Open();
                string sql = "SELECT IDENT_CURRENT('"+ _columnName + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                lastID = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occurred", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return lastID;
        }



        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }


        private static Regex PasswordValidation()
        {
            string pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        static Regex vaildate_password = PasswordValidation();

        public static Boolean validatePassword(TextBox _passbox)
        {
            Boolean myReturn = true;
            if (vaildate_password.IsMatch(_passbox.Text) != true)
            {
                MessageBox.Show("Password must be atleast 8 to 15 characters. It contains atleast one Upper case and numbers.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Text Box Colour Change 
                _passbox.BackColor = Color.Red;
                myReturn = false;
            }
            else
            {
                _passbox.BackColor = Color.White;
                myReturn = true;
            }
            return myReturn;
        }

        /*public static void getLastInsertedID()
        {
            object newCusID = 0;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SCOPE_IDENTITY() AS lastInsertedID", con);
                newCusID = cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            } 
        }*/

        internal static Boolean checkUsername(string _sql)
        {
            Boolean returnValue = true; 

            /*con.Open();
            SqlCommand cmd = new SqlCommand(_sql, con);
            int count = cmd.ExecuteNonQuery();
            con.Close();

            if (count < 0)
            {
               MessageBox.Show("This username is already taken. Try using other username", "Username Already Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);

                returnValue = false;
            }
            else
            {
                returnValue = true;
            }
            */
            return returnValue;

        }

        public static string CreateRandomPassword(int length = 15)
        {
            // Create a string of characters, numbers, special characters that allowed in the password  
            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#";
            Random random = new Random();

            // Select one random character at a time from the string  
            // and create an array of chars  
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }

        internal static Boolean userLoginCheck(string _sql, Form _output)
        {
            Boolean myReturn = false;
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(_sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                int count = dt.Rows.Count;

                if (count == 1 )
                {
                    myReturn = true;  
                }
                else
                {
                    myReturn = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ooops!! Error in updating \n " + ex.Message, "Error Occurred", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return myReturn;
        }



        public static int calculateRemainingPayment(string _jobID)
        {
            DataTable loadJobGood = CommonFunctions.tableFun("SELECT * FROM load INNER JOIN job ON load.j_id_fk = job.j_id INNER JOIN good ON load.good_id_fk = good.good_id WHERE job.j_id = '" + _jobID + "'");

            int totalAmount = 0;

            string totaljobPayAmount = null;

            foreach (DataRow row in loadJobGood.Rows)
            {
                string quantity = row["quantity"].ToString();
                string goodAmount = row["good_initailAmount"].ToString();

                int totalLoadAmount = Convert.ToInt32(quantity) * Convert.ToInt32(goodAmount);

                totalAmount = totalLoadAmount + totalAmount;

                totaljobPayAmount = row["j_payable"].ToString();
            }

            int finalPayAmount = Convert.ToInt32(totaljobPayAmount) + totalAmount;

            DataTable payTable = CommonFunctions.tableFun("SELECT * FROM payment WHERE j_id_fk = '" + _jobID + "'");

            int initiallyPaid = 0;

            foreach (DataRow row in payTable.Rows)
            {
                string AlreadyPaidAmount = row["p_amount"].ToString();

                initiallyPaid = Convert.ToInt32(AlreadyPaidAmount) + initiallyPaid;

            }

            int remainPayment = finalPayAmount - initiallyPaid;

            return remainPayment;
        }



    }
}
