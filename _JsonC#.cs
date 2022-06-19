public static void Main(string[] args)
         {
            var my_jsondata = new
            {
                Host = @"sftp.myhost.gr",
                UserName = "my_username",
                Password = "my_password",
                SourceDir = "/export/zip/mypath/",
                FileName = "my_file.zip"
            };

            string json_data = JsonConvert.SerializeObject(my_jsondata);
            var jo = JObject.Parse(json_data);
            //var id = jo["report"]["Id"].ToString();  //=> Masuk ke Menu
            //var id = jo["Host"].ToString();          //=? Ambil data Id 
            //var id = jo["products"][1]["images"][1] // Ambil Data Object By Id dan Index Array jo["Object"][Index]["Object"][Index]
            //Console.WriteLine(id);
            Console.WriteLine(jo);
            Console.Read();
        }

//=====================================================================================================
//Source => https://www.newtonsoft.com/json/help/html/JsonPropertyName.htm

public class Videogame
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("release_date")]
    public DateTime ReleaseDate { get; set; }
}


Videogame starcraft = new Videogame
{
    Name = "Starcraft",
    ReleaseDate = new DateTime(1998, 1, 1)
};

string json = JsonConvert.SerializeObject(starcraft, Formatting.Indented);

Console.WriteLine(json);
// {
//   "name": "Starcraft",
//   "release_date": "1998-01-01T00:00:00"
// }
//=====================================================================================================

private async void GetData(int lineid)
        {
            RestClient _client = new RestClient();
            var request = new RestRequest("http://localhost/rhest-api/trial.json", Method.Get);
            var response = await _client.ExecuteAsync(request);
            var isi = Convert.ToString(response.Content);
            data_source = JsonConvert.DeserializeObject<List<AddProduct>>(isi);
            //string id = Convert.ToString(data_source.createdBy.application.id);
            //var date = JsonConvert.DeserializeObject(response.Content);
            if (response.IsSuccessful == true)
            {
                // var data = response.ContentLength.ToString();
                // var id = response.Request.s
                //var isi = response.Content.ToString();
                //var deptList = JsonSe
                dataGridView1.DataSource = data_source;
                //textBox1.Text = isi;
                dataGridView1.Columns[0].Width = 250;
                dataGridView1.Columns[1].Width = 250;
                dataGridView1.Columns[2].Width = 250;
             
               
             

            }
        }

//==================================================================================================================        
 private async void button2_Click(object sender, EventArgs e)
        {
            RestClient _client = new RestClient();
            var request = new RestRequest("http://127.0.0.1:3000/posts", Method.Post);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new AddProduct
            {
                author = textBox2.Text,
                title = textBox3.Text
            });
            
            var response = await _client.ExecuteAsync(request);
            
            if (response.IsSuccessful == true)

            {
                var data = response.StatusCode;
            }

            else
            {
                MessageBox.Show(response.ErrorMessage);
            }
        }
        
 
//==================================================================================================================
  private async void button3_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;
            RestClient _client = new RestClient();
            var request = new RestRequest("http://localhost/rhest-api/trial.json" + id, Method.Delete);
            var response = await _client.ExecuteAsync(request);
            if (response.IsSuccessful == true)
            {
            }
        }
        
//==================================================================================================================        
  private async void button4_Click(object sender, EventArgs e)
        {
            var id = textBox1.Text;
            RestClient _client = new RestClient();
            var request = new RestRequest("http://127.0.0.1:3000/posts/" + id, Method.Put);
            request.AddBody(new AddProduct
            {
                author = textBox2.Text,
                title = textBox3.Text
            });
            var response = await _client.ExecuteAsync(request);

        }

 
