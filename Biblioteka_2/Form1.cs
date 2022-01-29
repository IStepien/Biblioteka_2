using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System;
using System.IO;


namespace Biblioteka
{
    public partial class Form1 : Form

    {
        public bool isAdmin;
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataReader dataReader2;
        public String conString;
        int bookId;
        int rating;
        
        public bool passingvalue
        {

            get { return isAdmin; }
            set { isAdmin = value; }
        }
        public String connString
        {

            get { return conString; }
            set { conString = value; }
        }

        public Form1()
        {
           
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isAdmin = passingvalue;
            if(passingvalue)
            {
                btnAdd.Visible = true;
                btnEditBook.Visible = true;
            }
           


            getTopRated();

            getGenres();
          

        }       
             

        private void comBGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBAuthor.Items.Clear();
            comBTitle.Items.Clear();
            string currentGenre = comBGenre.SelectedItem.ToString();
            getAuthors(currentGenre);
            picBBook.Image = null;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            getAllAuthors();
            comBAuthor.Items.Clear();
            comBTitle.Items.Clear();

            btnAdd.Visible = false;
            btnCancel.Visible = true;
            picBBook.Image = null;
            btnAddPicture.Visible = true;
            btnEditBook.Visible = false;
            btnSBook.Visible = true;
            valueSelection.Visible = true;

            comBGenre.DropDownStyle = ComboBoxStyle.DropDown;
            comBAuthor.DropDownStyle = ComboBoxStyle.DropDown;
            comBTitle.DropDownStyle = ComboBoxStyle.DropDown;

           
        }

        private void comBAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            comBTitle.Items.Clear();
            picBBook.Image = null;
            string currentAuthor = comBAuthor.SelectedItem.ToString();
            getTitles(currentAuthor);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            comBGenre.Visible = true;
            comBAuthor.Visible = true;
            comBTitle.Visible = true;


            btnAdd.Visible = true;
            btnCancel.Visible = false;
            btnAddPicture.Visible = false;
            btnUpdateBook.Visible = false;

            btnEditBook.Visible = true;
            btnSBook.Visible = false;

            picBBook.Image = null;
            valueSelection.Visible = false;


            comBGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comBAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comBTitle.DropDownStyle = ComboBoxStyle.DropDownList;


        }


        private void btnAddPicture_Click(object sender, EventArgs e)
        {

            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files (*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picBBook.ImageLocation = imageLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Wystapił błąd");
            }


        }
        private void btnEditBook_Click(object sender, EventArgs e)
        {
            string genre = comBGenre.Text;
            string author = comBAuthor.Text;
            string title = comBTitle.Text;
            btnCancel.Visible = true;
            btnAdd.Visible = false;
            int bookId = getBookId(genre, author, title);
            btnEditBook.Visible = false;

        }

        private void comBTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            picBBook.Image = null;
            uploadPicture();
            if (!isAdmin)
            {
                valueSelection.Visible = true;
                btnAddRating.Visible = true;

            }
            else
            {
                btnEditBook.Visible = true;
            }

        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            string author = comBAuthor.Text;
            string genre = comBGenre.Text;
            string title = comBTitle.Text;
            


            if (author.Length > 0 && genre.Length > 0 && title.Length > 0)
            {
                saveBook(author, genre, title, rating);

                btnSBook.Visible = false;
                btnCancel.Visible = false;
                btnAdd.Visible = true;
                btnEditBook.Visible = true;

                comBGenre.Items.Clear();
                comBAuthor.Items.Clear();

                comBGenre.DropDownStyle = ComboBoxStyle.DropDownList;
                comBAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
                comBTitle.DropDownStyle = ComboBoxStyle.DropDownList;

                valueSelection.Visible = false;

                picBBook.Image = null;

                getGenres();

            }
            else
            {
                MessageBox.Show("Pole nie może być puste");
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            btnAddPicture.Visible = true;

            updateBook(bookId);

            btnSBook.Visible = false;
            btnCancel.Visible = false;
            btnAddPicture.Visible = false;
            btnUpdateBook.Visible = false;
            btnEditBook.Visible = true;

            comBGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comBAuthor.DropDownStyle = ComboBoxStyle.DropDownList;
            comBTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            valueSelection.Visible = false;
            valueSelection.clearPcBoxes(); 
            comBAuthor.Items.Clear();
            comBTitle.Items.Clear();
            btnAdd.Visible = true; ;
            getGenres();
            getTopRated();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

     

        private void getGenres()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();
                cmd = new SqlCommand("Select distinct genre from Books", connection);

                dataReader2 = cmd.ExecuteReader();

                while (dataReader2.Read())
                {
                    if (!comBGenre.Items.Contains(dataReader2[0].ToString()))
                    {
                    comBGenre.Items.Add(dataReader2[0].ToString());
                    }
                }
                connection.Close();
            }
        }
        private void getAuthors(string genre)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();
                cmd = new SqlCommand("Select distinct author from Books where genre =@genre", connection);
                cmd.Parameters.Add(new SqlParameter("@genre", genre));

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    comBAuthor.Items.Add(dataReader[0].ToString());                    
                }

                connection.Close();

            }
        }

        private void getTitles(string author)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();
                cmd = new SqlCommand("Select title from Books where author =@author", connection);
                cmd.Parameters.Add(new SqlParameter("@author", author));

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    comBTitle.Items.Add(dataReader[0].ToString());
                }
            }
        }



        private void saveBook(string author, string genre, string title, int rating)
        {
            int currentRating = getRating(author, genre, title) + rating;
            int currentRatingCount = getCurrentRatingCount(author, genre, title)+1;


            int numberOfCopies = checkNumberOfCopies(author, genre, title);
            if (numberOfCopies < 1)
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = conString;
                    connection.Open();
                    if (picBBook.Image != null)
                    {
                        Image img = picBBook.Image;
                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] bytes = ms.ToArray();


                        string query = "Insert into Books " + "(Genre, Author, Title, Photo, Copies, RatingValue, RatingCount)" + "Values (@Genre, @Author, @Title, @Photo, 1, @RatingValue, @RatingCount)";
                        cmd = new SqlCommand(query, connection);
                        cmd.Parameters.Add(new SqlParameter("@author", author));
                        cmd.Parameters.Add(new SqlParameter("@genre", genre));
                        cmd.Parameters.Add(new SqlParameter("@title", title));
                        cmd.Parameters.Add(new SqlParameter("@Photo", bytes));
                        cmd.Parameters.Add(new SqlParameter("@RatingValue", currentRating));
                        cmd.Parameters.Add(new SqlParameter("@RatingCount", currentRatingCount));
                    }
                    else
                    {
                        string query = "Insert into Books " + "(Genre, Author, Title, Photo, Copies, RatingValue, RatingCount)" + "Values (@Genre, @Author, @Title, NULL, 1, @RatingValue, @RatingCount)";
                        cmd = new SqlCommand(query, connection);
                        cmd.Parameters.Add(new SqlParameter("@author", author));
                        cmd.Parameters.Add(new SqlParameter("@genre", genre));
                        cmd.Parameters.Add(new SqlParameter("@title", title));
                        cmd.Parameters.Add(new SqlParameter("@RatingValue", currentRating));
                        cmd.Parameters.Add(new SqlParameter("@RatingCount", currentRatingCount));
                    }
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Zapisano", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();
                }

            }
            else
            {
                updateBookCopies(author, genre, title, numberOfCopies);
            }


            picBBook.Image = null;
            btnAddPicture.Visible = false;
            btnAdd.Visible = true;
            getTopRated();

        }

        

        private int checkNumberOfCopies(string author, string genre, string title)
        {
            int numberOfCopies;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();
                cmd = new SqlCommand("Select copies from Books where author =@author and genre=genre and title=@title", connection);                
                cmd.Parameters.Add(new SqlParameter("@author", author));
                cmd.Parameters.Add(new SqlParameter("@genre", genre));
                cmd.Parameters.Add(new SqlParameter("@title", title));


                numberOfCopies = Convert.ToInt32(cmd.ExecuteScalar());
                if(DBNull.Value.Equals(numberOfCopies))
                {
                    numberOfCopies = 1;
                }
            }

            return numberOfCopies;
        }
        private int getRating(string author, string genre, string title)
        {
            int currentRating;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();
                cmd = new SqlCommand("Select RatingValue from Books where author =@author and genre=genre and title=@title", connection);
                cmd.Parameters.Add(new SqlParameter("@author", author));
                cmd.Parameters.Add(new SqlParameter("@genre", genre));
                cmd.Parameters.Add(new SqlParameter("@title", title));


                currentRating = Convert.ToInt32(cmd.ExecuteScalar());
               
            } 


                return currentRating;
        }

        private int getCurrentRatingCount(string author, string genre, string title)
        {
            int currentRatingCount;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();
                cmd = new SqlCommand("Select RatingCount from Books where author =@author and genre=genre and title=@title", connection);
                cmd.Parameters.Add(new SqlParameter("@author", author));
                cmd.Parameters.Add(new SqlParameter("@genre", genre));
                cmd.Parameters.Add(new SqlParameter("@title", title));


                currentRatingCount = Convert.ToInt32(cmd.ExecuteScalar());
               
            }


            return currentRatingCount;
        }



        private void updateBookCopies(string author, string genre, string title, int copies)
        {
            int numberOfCopies = copies + 1;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();
                cmd = new SqlCommand("Update Books set Copies=@Copies where author =@author and genre=@genre and title=@title", connection);
                cmd.Parameters.Add(new SqlParameter("@author", author));
                cmd.Parameters.Add(new SqlParameter("@genre", genre));
                cmd.Parameters.Add(new SqlParameter("@title", title));
                cmd.Parameters.Add(new SqlParameter("@Copies", numberOfCopies));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Zapisano", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

            }
        }

            
        private void uploadPicture()
        {
            
            string genre = comBGenre.Text;
            string author = comBAuthor.Text;
            string title = comBTitle.Text;
           

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();
                cmd = new SqlCommand("Select Photo from Books where author =@author and genre=@genre and title=@title", connection);
                cmd.Parameters.Add(new SqlParameter("@author", author));
                cmd.Parameters.Add(new SqlParameter("@genre", genre));
                cmd.Parameters.Add(new SqlParameter("@title", title));


                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                {
                    DataSet dataSet = new DataSet();
                    dataAdapter.Fill(dataSet);

                    if (dataSet.Tables[0].Rows.Count == 1 && !DBNull.Value.Equals(dataSet.Tables[0].Rows[0]["Photo"]))
                    {
                        
                        Byte[] data = new Byte[0];
                        data = (Byte[])(dataSet.Tables[0].Rows[0]["Photo"]);
                        MemoryStream mem = new MemoryStream(data);
                        picBBook.Image = Image.FromStream(mem);
                    }
                 
                
             
                }
                connection.Close();
                
            }

        }

     
      
        private void getAllAuthors()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();
                cmd = new SqlCommand("Select distinct author from Books", connection);
              
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    comBAuthor.Items.Add(dataReader[0].ToString());
                }

                connection.Close();

            }
        }

        private int getBookId(string genre, string author, string title)
        {
            
            if (genre.Length > 0 && author.Length > 0 && title.Length > 0)
            {
                valueSelection.Visible = true;

                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = conString;
                    connection.Open();


                    cmd = new SqlCommand("Select id from Books where author=@author and genre=@genre and title=@title", connection);
                    cmd.Parameters.Add(new SqlParameter("@author", author));
                    cmd.Parameters.Add(new SqlParameter("@genre", genre));
                    cmd.Parameters.Add(new SqlParameter("@title", title));



                    bookId = Convert.ToInt32(cmd.ExecuteScalar());

                    connection.Close();

                    if (isAdmin)
                    { 

                    comBGenre.DropDownStyle = ComboBoxStyle.DropDown;
                    comBAuthor.DropDownStyle = ComboBoxStyle.DropDown;
                    comBTitle.DropDownStyle = ComboBoxStyle.DropDown;


                    btnUpdateBook.Visible = true;
                    btnAddPicture.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Wybierz konkretną książkę do edycji");
            }
            

            return bookId;
        }

        private void updateBook(int bookId)
        {
            string genre = comBGenre.Text;
            string author = comBAuthor.Text;
            string title = comBTitle.Text;

            if (genre.Length > 0 && author.Length > 0 && title.Length > 0)
            {

                int currentRating = getRating(author, genre, title)+rating;
                int currentRatingCount = getCurrentRatingCount(author, genre, title)+1;

                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = conString;
                    connection.Open();

                    if (picBBook.Image != null)
                    {
                        Image img = picBBook.Image;
                        MemoryStream ms = new MemoryStream();
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] bytes = ms.ToArray();

                        cmd = new SqlCommand("Update Books set  author=@author, genre=@genre, title=@title, photo=@photo, ratingValue=@rating, ratingCount=@ratingCount  where Id=@Id", connection);
                        cmd.Parameters.Add(new SqlParameter("@author", author));
                        cmd.Parameters.Add(new SqlParameter("@genre", genre));
                        cmd.Parameters.Add(new SqlParameter("@title", title));
                        cmd.Parameters.Add(new SqlParameter("@Id", bookId));
                        cmd.Parameters.Add(new SqlParameter("@photo", bytes));
                        cmd.Parameters.Add(new SqlParameter("@rating", currentRating));
                        cmd.Parameters.Add(new SqlParameter("@ratingCount", currentRatingCount));
                    }
                    else
                    {
                        cmd = new SqlCommand("Update Books set  author=@author, genre=@genre, title=@title,ratingValue=@rating, ratingCount=@ratingCount where Id=@Id", connection);
                        cmd.Parameters.Add(new SqlParameter("@author", author));
                        cmd.Parameters.Add(new SqlParameter("@genre", genre));
                        cmd.Parameters.Add(new SqlParameter("@title", title));
                        cmd.Parameters.Add(new SqlParameter("@Id", bookId));
                        cmd.Parameters.Add(new SqlParameter("@rating", currentRating));
                        cmd.Parameters.Add(new SqlParameter("@ratingCount", currentRatingCount ));

                    }

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Zapisano", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Pole nie może być puste");
            }
            
            
        }

        

      private void valueSelection_valueChanged(object sender, EventArgs e)
        {
           this.rating = valueSelection.RatingValue;
          
        }
        private void getTopRated()
        {
            lBoxTopRated.Items.Clear();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = conString;
                connection.Open();


                cmd = new SqlCommand("Select top (3) author, title, RatingValue/Ratingcount as rating from Books order by rating desc", connection);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    lBoxTopRated.Items.Add(dataReader[0].ToString()+ ' '+'"'+ dataReader[1].ToString().Trim()+ '"');
                    
                }

                connection.Close();              


            }
        }

        private void btnAddRating_Click(object sender, EventArgs e)
        {
            string genre = comBGenre.Text;
            string author = comBAuthor.Text;
            string title = comBTitle.Text;
            updateBook(getBookId(genre,author,title));
            valueSelection.clearPcBoxes();
            getTopRated();
        }
    }
}
