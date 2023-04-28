using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;
using static Ecommerce.Form1;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Reflection;
using ImageButton;
using System.ComponentModel.Design;
using System.Security.AccessControl;

namespace Ecommerce
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            createWindowLogin();
            Opacity = 0;
            Visible = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public static void cadastroUser(object sender, EventArgs e)
        {

            //janela
            componentes.cadastroDisplay = new Form();
            componentes.cadastroDisplay.Size = new Size(360, 360);
            componentes.cadastroDisplay.BackColor = Color.DarkBlue;
            componentes.cadastroDisplay.Visible = true;
            componentes.cadastroDisplay.BringToFront();
            componentes.cadastroDisplay.Enabled = true;
            componentes.cadastroDisplay.FormBorderStyle = FormBorderStyle.None;
            componentes.cadastroDisplay.Location = new Point(470, 130);

            componentes.tituloWindowCadastro = new Label();
            componentes.tituloWindowCadastro.Text = "Cadastro de usuários";
            componentes.tituloWindowCadastro.Font = new Font("Arial", 14, FontStyle.Regular);
            componentes.tituloWindowCadastro.Size = new Size(300, 20);
            componentes.tituloWindowCadastro.ForeColor = Color.White;
            componentes.tituloWindowCadastro.Location = new Point(16, 20);
            componentes.tituloWindowCadastro.Visible = true;
            componentes.tituloWindowCadastro.Parent = componentes.cadastroDisplay;

            componentes.userBox = new TextBox();
            componentes.userBox.Size = new Size(200, 23);
            componentes.userBox.Visible = true;
            componentes.userBox.Location = new Point(20, 60);
            componentes.userBox.Parent = componentes.cadastroDisplay;

            componentes.userName = new Label();
            componentes.userName.Text = "Nome";
            componentes.userName.ForeColor = Color.White;
            componentes.userName.Font = new Font("Arial", 10, FontStyle.Regular);
            componentes.userName.Location = new Point(250, 60);
            componentes.userName.Visible = true;
            componentes.userName.Parent = componentes.cadastroDisplay;

            componentes.emailBox = new TextBox();
            componentes.emailBox.Size = new Size(200, 23);
            componentes.emailBox.Visible = true;
            componentes.emailBox.Location = new Point(20, 120);
            componentes.emailBox.Parent = componentes.cadastroDisplay;

            componentes.emailName = new Label();
            componentes.emailName.Font = new Font("Arial", 10, FontStyle.Regular);
            componentes.emailName.Text = "E-mail";
            componentes.emailName.ForeColor = Color.White;
            componentes.emailName.Location = new Point(250, 120);
            componentes.emailName.Visible = true;
            componentes.emailName.Parent = componentes.cadastroDisplay;
            componentes.emailName.BringToFront();

            componentes.senhaBox = new TextBox();
            componentes.senhaBox.Size = new Size(200, 23);
            componentes.senhaBox.Visible = true;
            componentes.senhaBox.Location = new Point(20, 180);
            componentes.senhaBox.Parent = componentes.cadastroDisplay;

            componentes.senhaName = new Label();
            componentes.senhaName.Font = new Font("Arial", 10, FontStyle.Regular);
            componentes.senhaName.Text = "Senha";
            componentes.senhaName.ForeColor = Color.White;
            componentes.senhaName.Location = new Point(250, 180);
            componentes.senhaName.Visible = true;
            componentes.senhaName.Parent = componentes.cadastroDisplay;

            componentes.numeroBox = new TextBox();
            componentes.numeroBox.Size = new Size(200, 23);
            componentes.numeroBox.Visible = true;
            componentes.numeroBox.Location = new Point(20, 240);
            componentes.numeroBox.Parent = componentes.cadastroDisplay;

            componentes.numeroName = new Label();
            componentes.numeroName.Font = new Font("Arial", 10, FontStyle.Regular);
            componentes.numeroName.Text = "Endereço";
            componentes.numeroName.ForeColor = Color.White;
            componentes.numeroName.Location = new Point(250, 240);
            componentes.numeroName.Visible = true;
            componentes.numeroName.Parent = componentes.cadastroDisplay;

            componentes.finalizarCadastro = new Button();
            componentes.finalizarCadastro.Text = "Cadastar";
            componentes.finalizarCadastro.Size = new Size(80, 30);
            componentes.finalizarCadastro.Location = new Point(19, 275);
            componentes.finalizarCadastro.Visible = true;
            componentes.finalizarCadastro.Parent = componentes.cadastroDisplay;
            componentes.finalizarCadastro.BringToFront();
            componentes.finalizarCadastro.ForeColor = Color.White;
            componentes.finalizarCadastro.BackColor = Color.DarkBlue;
            componentes.finalizarCadastro.FlatStyle = FlatStyle.Flat;
            componentes.finalizarCadastro.FlatAppearance.BorderColor = Color.DarkCyan;
            componentes.finalizarCadastro.Click += cadastramento2;


            componentes.fecharCadastro = new Button();
            componentes.fecharCadastro.Text = "Fechar";
            componentes.fecharCadastro.Size = new Size(80, 30);
            componentes.fecharCadastro.Location = new Point(140, 275);
            componentes.fecharCadastro.Visible = true;
            componentes.fecharCadastro.Parent = componentes.cadastroDisplay;
            componentes.fecharCadastro.BringToFront();
            componentes.fecharCadastro.ForeColor = Color.White;
            componentes.fecharCadastro.BackColor = Color.DarkBlue;
            componentes.fecharCadastro.FlatStyle = FlatStyle.Flat;
            componentes.fecharCadastro.FlatAppearance.BorderColor = Color.DarkCyan;
            componentes.fecharCadastro.Click += fecharJanelaCadastro;
            //campos de texto

        }


        public static void fecharJanelaCadastro(object sender, EventArgs e)
        {
            componentes.cadastroDisplay.Enabled = false;
            componentes.cadastroDisplay.Visible = false;
        }

        public void cadastrarButton(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        public async static void consultarProdutos(object sender, EventArgs e)
        {

            HttpClient client = new HttpClient();

            // Defina a URL do endpoint no NGINX que será encaminhado para a API na cloud
            string url = "https://api.chucknorris.io/jokes/categories";

            // Crie uma instância do objeto HttpRequestMessage com o método HTTP e a URL corretos
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

            try
            {
                // Envie a requisição usando o método SendAsync() do HttpClient
                HttpResponseMessage response = await client.SendAsync(request);

                // Verifique se a resposta indica sucesso
                if (response.IsSuccessStatusCode)
                {
                    // Leia o conteúdo da resposta como uma string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Desserialize o JSON de produtos em um objeto C#
                    List<string> produtos = JsonConvert.DeserializeObject<List<string>>(responseBody);

                    // Exiba os produtos em uma mensagem box
                    StringBuilder mensagem = new StringBuilder();
                    foreach (string produto in produtos)
                    {
                        mensagem.AppendLine(produto);
                    }

                    MessageBox.Show(mensagem.ToString());
                }
                else
                {
                    Console.WriteLine("Erro ao enviar requisição: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }


        public async static void consult()
        {
            var httpClient = new HttpClient();//inicia o client

            // Set the base URL of the API endpoint
            httpClient.BaseAddress = new Uri("http://20.219.225.238/");//passa url de acesso

            // Send an HTTP GET request to the API endpoint
            var response = await httpClient.GetAsync("products");//passa a rota assincrona de acesso para url

            // Check if the response was successful
            if (response.IsSuccessStatusCode)//verifica se recebeu uma resposta
            {
                // Get the response body as a string
                var responseBody = await response.Content.ReadAsStringAsync();//ler a resposta do servidor
                List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(responseBody);//desserializa, ou seja, organiza e separa as palavras do json

                // Mapeia cada produto para um novo objeto com a propriedade "id"
                var produtosComId = produtos.Select((p, i) => new { Id = i + 1, Produto = p }).ToList();

                foreach(Produto i in produtos)
                {
                    componentes.idDesejado += 1;

                    var produtoComId = produtosComId.Find(p => p.Id == componentes.idDesejado);//busca o id na lista

                    if (produtoComId != null)//se o id for diferente de null
                    {
                        if (componentes.idDesejado == 1)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto1.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto1.BackgroundImage = Properties.Resources.sausages;
                        }

                        if (componentes.idDesejado == 2)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto2.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto2.BackgroundImage = Properties.Resources.sausage2;
                        }

                        if (componentes.idDesejado == 3)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto3.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto3.BackgroundImage = Properties.Resources.cottons;
                        }

                        if (componentes.idDesejado == 4)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto4.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto4.BackgroundImage = Properties.Resources.salad3;
                        }

                        if (componentes.idDesejado == 5)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto5.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto5.BackgroundImage = Properties.Resources.fish2;
                        }


                        if (componentes.idDesejado == 6)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto6.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto6.BackgroundImage = Properties.Resources.shirt2;
                        }

                        if (componentes.idDesejado == 7)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto7.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto7.BackgroundImage = Properties.Resources.pizza;
                        }

                        if (componentes.idDesejado == 8)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto8.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto8.BackgroundImage = Properties.Resources.chair3;
                        }

                        if (componentes.idDesejado == 9)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto9.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto9.BackgroundImage = Properties.Resources.salad5;
                        }

                        if (componentes.idDesejado == 10)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto10.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto10.BackgroundImage = Properties.Resources.concretSalad1;
                        }

                        if (componentes.idDesejado == 11)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto11.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto11.BackgroundImage = Properties.Resources.concretChair2;
                        }

                        if (componentes.idDesejado == 12)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto12.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto12.BackgroundImage = Properties.Resources.steelSoap2;
                        }

                        if (componentes.idDesejado == 13)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto13.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto13.BackgroundImage = Properties.Resources.shirtMetal3;
                        }

                        if (componentes.idDesejado == 14)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto14.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto14.BackgroundImage = Properties.Resources.carGranite2;
                        }

                        if (componentes.idDesejado == 15)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto15.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto15.BackgroundImage = Properties.Resources.iceShoes1;
                        }


                    }
                }
                 // ID do produto que você deseja buscar

               

            }
            else
            {
                // Handle the error
                Console.WriteLine($"API request failed with status code {response.StatusCode}");
            }
        }


        public async static void filtroComida(object sender, EventArgs e)
        {
            componentes.idDesejado = 0;
            var httpClient = new HttpClient();//inicia o client

            // Set the base URL of the API endpoint
            httpClient.BaseAddress = new Uri("http://20.219.225.238/");//passa url de acesso

            // Send an HTTP GET request to the API endpoint
            var response = await httpClient.GetAsync("products");//passa a rota assincrona de acesso para url

            // Check if the response was successful
            if (response.IsSuccessStatusCode)//verifica se recebeu uma resposta
            {
                // Get the response body as a string
                var responseBody = await response.Content.ReadAsStringAsync();//ler a resposta do servidor
                List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(responseBody);//desserializa, ou seja, organiza e separa as palavras do json

                // Mapeia cada produto para um novo objeto com a propriedade "id"
                var produtosComId = produtos.Select((p, i) => new { Id = i + 1, Produto = p }).ToList();

                foreach (Produto i in produtos)
                {
                    componentes.idDesejado += 1;

                    var produtoComId = produtosComId.Find(p => p.Id == componentes.idDesejado);//busca o id na lista

                    if (produtoComId != null)//se o id for diferente de null
                    {
                        if (componentes.idDesejado == 1)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto1.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto1.BackgroundImage = Properties.Resources.sausages;
                            componentes.SlotProduto1.BackColor = Color.Blue;
                        }

                        if (componentes.idDesejado == 2)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto2.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto2.BackgroundImage = Properties.Resources.sausage2;
                            componentes.SlotProduto2.BackColor = Color.Blue;
                        }

                        if (componentes.idDesejado == 4)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto3.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto3.BackgroundImage = Properties.Resources.salad3;
                            componentes.SlotProduto3.BackColor = Color.Blue;
                        }

                        if (componentes.idDesejado == 5)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto4.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto4.BackgroundImage = Properties.Resources.fish2;
                            componentes.SlotProduto4.BackColor = Color.Blue;
                        }

                        if (componentes.idDesejado == 7)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto5.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto5.BackgroundImage = Properties.Resources.pizza;
                            componentes.SlotProduto5.BackColor = Color.Blue;
                        }

                        }
                    }

                }
            }

        public async static void filtroSapato(object sender, EventArgs e)
        {
            componentes.idDesejado = 0;
            var httpClient = new HttpClient();//inicia o client

            // Set the base URL of the API endpoint
            httpClient.BaseAddress = new Uri("http://20.219.225.238/");//passa url de acesso

            // Send an HTTP GET request to the API endpoint
            var response = await httpClient.GetAsync("products");//passa a rota assincrona de acesso para url

            // Check if the response was successful
            if (response.IsSuccessStatusCode)//verifica se recebeu uma resposta
            {
                // Get the response body as a string
                var responseBody = await response.Content.ReadAsStringAsync();//ler a resposta do servidor
                List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(responseBody);//desserializa, ou seja, organiza e separa as palavras do json

                // Mapeia cada produto para um novo objeto com a propriedade "id"
                var produtosComId = produtos.Select((p, i) => new { Id = i + 1, Produto = p }).ToList();

                foreach (Produto i in produtos)
                {
                    componentes.idDesejado += 1;

                    var produtoComId = produtosComId.Find(p => p.Id == componentes.idDesejado);//busca o id na lista

                    if (produtoComId != null)//se o id for diferente de null
                    {
                 

                        if (componentes.idDesejado == 15)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto1.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto1.BackgroundImage = Properties.Resources.iceShoes1;
                            componentes.SlotProduto1.BackColor = Color.Blue;
                            componentes.SlotProduto2.BackColor = Color.Orange;
                            componentes.SlotProduto3.BackColor = Color.Orange;
                            componentes.SlotProduto4.BackColor = Color.Orange;
                            componentes.SlotProduto5.BackColor = Color.Orange;
                            componentes.SlotProduto6.BackColor = Color.Orange;
                            componentes.SlotProduto7.BackColor = Color.Orange;
                            componentes.SlotProduto8.BackColor = Color.Orange;
                            componentes.SlotProduto9.BackColor = Color.Orange;
                            componentes.SlotProduto10.BackColor = Color.Orange;
                            componentes.SlotProduto11.BackColor = Color.Orange;
                            componentes.SlotProduto12.BackColor = Color.Orange;
                            componentes.SlotProduto13.BackColor = Color.Orange;
                            componentes.SlotProduto14.BackColor = Color.Orange;
                            componentes.SlotProduto15.BackColor = Color.Orange;



                        }

                    }
                }

            }
        }
        public async static void filtroRoupa(object sender, EventArgs e)
        {
            componentes.idDesejado = 0;
            var httpClient = new HttpClient();//inicia o client

            // Set the base URL of the API endpoint
            httpClient.BaseAddress = new Uri("http://20.219.225.238/");//passa url de acesso

            // Send an HTTP GET request to the API endpoint
            var response = await httpClient.GetAsync("products");//passa a rota assincrona de acesso para url

            // Check if the response was successful
            if (response.IsSuccessStatusCode)//verifica se recebeu uma resposta
            {
                // Get the response body as a string
                var responseBody = await response.Content.ReadAsStringAsync();//ler a resposta do servidor
                List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(responseBody);//desserializa, ou seja, organiza e separa as palavras do json

                // Mapeia cada produto para um novo objeto com a propriedade "id"
                var produtosComId = produtos.Select((p, i) => new { Id = i + 1, Produto = p }).ToList();

                foreach (Produto i in produtos)
                {
                    componentes.idDesejado += 1;

                    var produtoComId = produtosComId.Find(p => p.Id == componentes.idDesejado);//busca o id na lista

                    if (produtoComId != null)//se o id for diferente de null
                    {
                        if (componentes.idDesejado == 3)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto1.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto1.BackgroundImage = Properties.Resources.cottons;
                            componentes.SlotProduto1.BackColor = Color.Blue;
                        }

                        if (componentes.idDesejado == 6)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto2.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto2.BackgroundImage = Properties.Resources.shirt2;
                            componentes.SlotProduto2.BackColor = Color.Blue;
                        }

                        if (componentes.idDesejado == 13)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto3.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto3.BackgroundImage = Properties.Resources.shirtMetal3;
                            componentes.SlotProduto3.BackColor = Color.Blue;
                            componentes.SlotProduto4.BackColor = Color.Orange;
                            componentes.SlotProduto5.BackColor = Color.Orange;
                            componentes.SlotProduto6.BackColor = Color.Orange;
                            componentes.SlotProduto7.BackColor = Color.Orange;
                            componentes.SlotProduto8.BackColor = Color.Orange;
                            componentes.SlotProduto9.BackColor = Color.Orange;
                            componentes.SlotProduto10.BackColor = Color.Orange;
                            componentes.SlotProduto11.BackColor = Color.Orange;
                            componentes.SlotProduto12.BackColor = Color.Orange;
                            componentes.SlotProduto13.BackColor = Color.Orange;
                            componentes.SlotProduto14.BackColor = Color.Orange;
                            componentes.SlotProduto15.BackColor = Color.Orange;
                            


                        }

                    }
                }

            }
        }

        public async static void filtroMobilia(object sender, EventArgs e)
        {
            componentes.idDesejado = 0;
            var httpClient = new HttpClient();//inicia o client

            // Set the base URL of the API endpoint
            httpClient.BaseAddress = new Uri("http://20.219.225.238/");//passa url de acesso

            // Send an HTTP GET request to the API endpoint
            var response = await httpClient.GetAsync("products");//passa a rota assincrona de acesso para url

            // Check if the response was successful
            if (response.IsSuccessStatusCode)//verifica se recebeu uma resposta
            {
                // Get the response body as a string
                var responseBody = await response.Content.ReadAsStringAsync();//ler a resposta do servidor
                List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(responseBody);//desserializa, ou seja, organiza e separa as palavras do json

                // Mapeia cada produto para um novo objeto com a propriedade "id"
                var produtosComId = produtos.Select((p, i) => new { Id = i + 1, Produto = p }).ToList();

                foreach (Produto i in produtos)
                {
                    componentes.idDesejado += 1;

                    var produtoComId = produtosComId.Find(p => p.Id == componentes.idDesejado);//busca o id na lista

                    if (produtoComId != null)//se o id for diferente de null
                    {


                        if (componentes.idDesejado == 8)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto1.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto1.BackgroundImage = Properties.Resources.chair3;
                            componentes.SlotProduto1.BackColor = Color.Blue;
                         
                        }


                        if (componentes.idDesejado == 11)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto1.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto2.BackgroundImage = Properties.Resources.concretChair2;
                            componentes.SlotProduto2.BackColor = Color.Blue;

                            componentes.SlotProduto3.BackColor = Color.Orange;
                            componentes.SlotProduto4.BackColor = Color.Orange;
                            componentes.SlotProduto5.BackColor = Color.Orange;
                            componentes.SlotProduto6.BackColor = Color.Orange;
                            componentes.SlotProduto7.BackColor = Color.Orange;
                            componentes.SlotProduto8.BackColor = Color.Orange;
                            componentes.SlotProduto9.BackColor = Color.Orange;
                            componentes.SlotProduto10.BackColor = Color.Orange;
                            componentes.SlotProduto11.BackColor = Color.Orange;
                            componentes.SlotProduto12.BackColor = Color.Orange;
                            componentes.SlotProduto13.BackColor = Color.Orange;
                            componentes.SlotProduto14.BackColor = Color.Orange;
                            componentes.SlotProduto15.BackColor = Color.Orange;

                        }
                    }
                }

            }
        }
        public async static void filtroCozinha(object sender, EventArgs e)
        {
            componentes.idDesejado = 0;
            var httpClient = new HttpClient();//inicia o client

            // Set the base URL of the API endpoint
            httpClient.BaseAddress = new Uri("http://20.219.225.238/");//passa url de acesso

            // Send an HTTP GET request to the API endpoint
            var response = await httpClient.GetAsync("products");//passa a rota assincrona de acesso para url

            // Check if the response was successful
            if (response.IsSuccessStatusCode)//verifica se recebeu uma resposta
            {
                // Get the response body as a string
                var responseBody = await response.Content.ReadAsStringAsync();//ler a resposta do servidor
                List<Produto> produtos = JsonConvert.DeserializeObject<List<Produto>>(responseBody);//desserializa, ou seja, organiza e separa as palavras do json

                // Mapeia cada produto para um novo objeto com a propriedade "id"
                var produtosComId = produtos.Select((p, i) => new { Id = i + 1, Produto = p }).ToList();

                foreach (Produto i in produtos)
                {
                    componentes.idDesejado += 1;

                    var produtoComId = produtosComId.Find(p => p.Id == componentes.idDesejado);//busca o id na lista

                    if (produtoComId != null)//se o id for diferente de null
                    {


                        if (componentes.idDesejado == 15)
                        {
                            var produto = produtoComId.Produto;//
                            componentes.infoProduto1.Text = ($"Nome: {produto.name}\nDescrição: {produto.description}\nPreço: {produto.price}");
                            componentes.produto1.BackgroundImage = Properties.Resources.iceShoes1;
                            componentes.SlotProduto1.BackColor = Color.Blue;
                            componentes.SlotProduto2.BackColor = Color.Orange;
                            componentes.SlotProduto3.BackColor = Color.Orange;
                            componentes.SlotProduto4.BackColor = Color.Orange;
                            componentes.SlotProduto5.BackColor = Color.Orange;
                            componentes.SlotProduto6.BackColor = Color.Orange;
                            componentes.SlotProduto7.BackColor = Color.Orange;
                            componentes.SlotProduto8.BackColor = Color.Orange;
                            componentes.SlotProduto9.BackColor = Color.Orange;
                            componentes.SlotProduto10.BackColor = Color.Orange;
                            componentes.SlotProduto11.BackColor = Color.Orange;
                            componentes.SlotProduto12.BackColor = Color.Orange;
                            componentes.SlotProduto13.BackColor = Color.Orange;
                            componentes.SlotProduto14.BackColor = Color.Orange;
                            componentes.SlotProduto15.BackColor = Color.Orange;



                        }

                    }
                }

            }
        }
        // Defina uma classe Produto para desserializar o JSON retornado pela API
        public class Produto
        {
            public string name { get; set; }
            public string description { get; set; }
            public double price { get; set; }
        }

        public async static void cadastramento(object sender, EventArgs e){

            HttpClient client = new HttpClient();

            // Defina a URL do endpoint no NGINX que será encaminhado para a API na cloud
            string url = "http://20.219.225.238/";

            string email = componentes.emailBox.Text.ToString();
            string senha = componentes.senhaBox.Text.ToString();
            string endereco = componentes.numeroBox.Text.ToString();
            string nome = componentes.userBox.Text.ToString();

            var dadosAutenticacao = new Dictionary<string, string>
            {
                { "email", email },
                { "senha", senha },
                { "endereco", endereco },
                { "nome", nome }
            };

            string json = JsonConvert.SerializeObject(dadosAutenticacao);
            var conteudoRequisicao = new StringContent(json, Encoding.UTF8, "application/json");
            // Crie uma instância do objeto HttpRequestMessage com o método HTTP, a URL e o conteúdo da requisição
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = conteudoRequisicao;
            try
            {
                // Envie a requisição usando o método SendAsync() do HttpClient
                HttpResponseMessage response = await client.SendAsync(request);
               
                // Verifique se a resposta indica sucesso
                if (response.IsSuccessStatusCode)
                {
                    // Leia o conteúdo da resposta como uma string
                    
                    string responseBody = await response.Content.ReadAsStringAsync();
                    List<string> produtos = JsonConvert.DeserializeObject<List<string>>(responseBody);
                    StringBuilder info = new StringBuilder();
                    foreach(string i in produtos)
                    {
                        info.AppendLine(i.ToString());
                    }
                    MessageBox.Show(responseBody.ToString());
                    
                    
                    
                }
                else
                {
                    Console.WriteLine("Erro ao enviar requisição: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }


        }

        public async static void cadastramento2(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();//inicia o client

            // Set the base URL of the API endpoint
            httpClient.BaseAddress = new Uri("http://20.219.225.238/");//passa url de acesso

            string email2 = componentes.emailBox.Text.ToString();
            string senha2 = componentes.senhaBox.Text.ToString();
            string endereco2 = componentes.numeroBox.Text.ToString();
            string nome2 = componentes.userBox.Text.ToString();


            // Create a new object with the user's information
            var dadosAutenticacao = new Dictionary<string, string>
            {
                { "email", email2 },
                { "password", senha2 },
                { "adress", endereco2 },
                { "name", nome2 }
            };


            // Serialize the object to JSON
            var jsonContent = JsonConvert.SerializeObject(dadosAutenticacao);

            // Send an HTTP POST request with the JSON as the content to the API endpoint
            var response = await httpClient.PostAsync("costumers", new StringContent(jsonContent, Encoding.UTF8, "application/json"));

            // Check if the response was successful
            if (response.IsSuccessStatusCode)//verifica se recebeu uma resposta
            {
                // Get the response body as a string
                var responseBody = await response.Content.ReadAsStringAsync();//ler a resposta do servidor
                List<Object> produtos = JsonConvert.DeserializeObject<List<Object>>(responseBody);
                StringBuilder sb = new StringBuilder();
                foreach (Object i in produtos)
                {
                    sb.AppendLine(i.ToString());
                }
                MessageBox.Show(sb.ToString());
            }
            else
            {
                // Handle the error
                var statusCode = response.StatusCode;
                var reasonPhrase = response.ReasonPhrase;
                var errorMessage = $"API request failed with status code {statusCode} ({reasonPhrase}).";
                MessageBox.Show(errorMessage);
            }

        }
        public async static void login(object sender, EventArgs e)
        {
            componentes.idDesejado = 0;
            HttpClient client = new HttpClient();

            // Define the endpoint URL in NGINX that will be forwarded to the cloud API
            string url = "http://20.219.225.238/login";




            // Get the values of the email and password fields from the TextBoxes
            string emailLogin = componentes.emailText.Text.ToString();
            string senhaLogin = componentes.passwordText.Text.ToString();

            // Create an object Dictionary with the values of the email and password fields
            var dadosAutenticacao = new Dictionary<string, string>
            {
                { "email", emailLogin },
                { "password", senhaLogin }
            };

            // Serialize the Dictionary object to a JSON string
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(dadosAutenticacao);

            // Create a StringContent object with the JSON string
            var conteudoRequisicao = new StringContent(json, Encoding.UTF8, "application/json");

            // Create an instance of the HttpRequestMessage object with the HTTP method, URL, and request content
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = conteudoRequisicao;

            try
            {
                // Send the request using the SendAsync() method of the HttpClient
                HttpResponseMessage response = await client.SendAsync(request);

                // Check if the response indicates success
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response into a dictionary
                    Dictionary<string, string> responseDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseBody);

                    // Check if the email and password are in the dictionary
                    if (responseDictionary.First().Key != null)
                    {
                        createWindowProduct();
                        componentes.loginWindow.Visible = false;
                        componentes.loginWindow.Enabled = false;
                    }

                    Console.WriteLine(responseBody);
                }
                else
                {
                    MessageBox.Show("Usuário não cadastrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public static void createWindowLogin()
        {
            componentes.loginWindow = new Form();
            componentes.loginWindow.Size = new Size(354, 489);
            componentes.loginWindow.FormBorderStyle = FormBorderStyle.None;
            componentes.loginWindow.BackColor = Color.DodgerBlue;
            componentes.loginWindow.Visible = true;



            componentes.title = new Label();
            componentes.title.Visible = true;
            componentes.title.Size = new Size(220, 41);
            componentes.title.Text = "MarketPlace";
            componentes.title.Font = new Font("LOUD AND CLEAR PERSONAL USE", 30, FontStyle.Italic);
            componentes.title.Location = new Point(62, 80);
            componentes.title.ForeColor = Color.SandyBrown;
            componentes.title.Parent = componentes.loginWindow;

            componentes.titleEmail = new Label();
            componentes.titleEmail.Size = new Size(61, 21);
            componentes.titleEmail.Visible = true;
            componentes.titleEmail.Font = new Font("LOUD AND CLEAR PERSONAL USE", 14);
            componentes.titleEmail.Location = new Point(65, 174);
            componentes.titleEmail.Text = "E-mail";
            componentes.titleEmail.ForeColor = Color.SandyBrown;
            componentes.titleEmail.Parent = componentes.loginWindow;

            componentes.titleSenha = new Label();
            componentes.titleSenha.Size = new Size(61, 21);
            componentes.titleSenha.Visible = true;
            componentes.titleSenha.Font = new Font("LOUD AND CLEAR PERSONAL USE", 14);
            componentes.titleSenha.Location = new Point(65, 246);
            componentes.titleSenha.Text = "Senha";
            componentes.titleSenha.ForeColor = Color.SandyBrown;
            componentes.titleSenha.Parent = componentes.loginWindow;

            componentes.emailText = new TextBox();
            componentes.emailText.Visible = true;
            componentes.emailText.Location = new Point(69, 208);
            componentes.emailText.Size = new Size(200, 20);
            componentes.emailText.Parent = componentes.loginWindow;

            componentes.passwordText = new TextBox();
            componentes.passwordText.Visible = true;
            componentes.passwordText.Location = new Point(69, 279);
            componentes.passwordText.Size = new Size(200, 20);
            componentes.passwordText.Parent = componentes.loginWindow;

            componentes.cadastro = new Button();
            componentes.cadastro.Visible = true;
            componentes.cadastro.Location = new Point(183, 333);
            componentes.cadastro.Size = new Size(86, 33);
            componentes.cadastro.Text = "Cadastrar";
            componentes.cadastro.Click += cadastroUser;
            componentes.cadastro.BackColor = Color.White;
            componentes.cadastro.Parent = componentes.loginWindow;

            componentes.entrar = new Button();
            componentes.entrar.Visible = true;
            componentes.entrar.Location = new Point(69, 333);
            componentes.entrar.Size = new Size(86, 33);
            componentes.entrar.Text = "Entrar";
            componentes.entrar.BackColor = Color.White;
            componentes.entrar.Click += login;
            componentes.entrar.Parent = componentes.loginWindow;

            componentes.logoutLogin = new Button();
            componentes.logoutLogin.Visible = true;
            componentes.logoutLogin.Location = new Point(120, 400);
            componentes.logoutLogin.Size = new Size(86, 33);
            componentes.logoutLogin.Text = "Sair";
            componentes.logoutLogin.BackColor = Color.White;
            componentes.logoutLogin.Click += sairApp;
            componentes.logoutLogin.Parent = componentes.loginWindow;

            componentes.emailText.Text = "cardoso@gmail.com";
            componentes.passwordText.Text = "123";


        }

        public static void sairApp(object sender, EventArgs e)
        {
            foreach(Process pro in Process.GetProcessesByName("Ecommerce"))
            {
                pro.Kill();
            }
        }

        public static void createWindowProduct()
        {
            
            
            componentes.telaPrincipal = new Form();
            componentes.telaPrincipal.Size = new Size(2060, 1000);
            componentes.telaPrincipal.Visible = true;
            componentes.telaPrincipal.Enabled = true;
            componentes.telaPrincipal.BackColor = Color.DarkGray;
            componentes.telaPrincipal.Text = "Produtos da loja";

            componentes.topPanel = new Panel();
            componentes.topPanel.Size = new Size(320, 100);
            componentes.topPanel.Parent = componentes.telaPrincipal;
            componentes.topPanel.BackColor = Color.DodgerBlue;
            componentes.topPanel.Enabled = true;
            componentes.topPanel.Visible = true;

            //componentes.layoutRoll.Paint += (sender, e) => {
            //    int sombraSize = 20; // tamanho da sombra em pixels
            //    int alpha = 50; // transparência da sombra (0-255)
            //    Color cor = Color.Black; // cor da sombra

            //    // Desenha uma série de retângulos em camadas com cores cada vez mais transparentes
            //    for (int i = 1; i <= sombraSize; i++)
            //    {
            //        int transparency = alpha / sombraSize * i;
            //        Color shadowColor = Color.FromArgb(transparency, cor);
            //        e.Graphics.DrawRectangle(new Pen(shadowColor), i - 1, i - 1, componentes.layoutRoll.Width - i, componentes.layoutRoll.Height - i);
            //    }
            //};

            componentes.titleProducts = new Label();
            componentes.titleProducts.Font = new Font("LOUD AND CLEAR PERSONAL USE", 40, FontStyle.Italic);
            componentes.titleProducts.Parent = componentes.topPanel;
            componentes.titleProducts.Visible = true;
            componentes.titleProducts.Enabled = true;
            componentes.titleProducts.Text = "MARKET PLACE";
            componentes.titleProducts.BackColor = Color.Transparent;
            componentes.titleProducts.ForeColor = Color.Orange;
            componentes.titleProducts.Size = new Size(500, 500);
            componentes.titleProducts.Location = new Point(0, 14);

            componentes.produtoTitle = new Panel();
            componentes.produtoTitle.Size = new Size(320, 50);
            componentes.produtoTitle.Location = new Point(0, 100);
            componentes.produtoTitle.Parent = componentes.telaPrincipal;
            componentes.produtoTitle.BackColor = Color.Orange;
            componentes.produtoTitle.Enabled = true;
            componentes.produtoTitle.Visible = true;

            componentes.menu = new Panel();
            componentes.menu.Size = new Size(320, 1100);
            componentes.menu.Location = new Point(0, 50);
            componentes.menu.Parent = componentes.telaPrincipal;
            componentes.menu.BackColor = Color.DodgerBlue;
            componentes.menu.Enabled = true;
            componentes.menu.Visible = true;

            componentes.userIcon = new Panel();
            componentes.userIcon.Size = new Size(50, 50);
            componentes.userIcon.Location = new Point(6, 220);
            componentes.userIcon.Parent = componentes.menu;
            componentes.userIcon.BackColor = Color.DodgerBlue;
            componentes.userIcon.Enabled = true;
            componentes.userIcon.Visible = true;
            componentes.userIcon.BackgroundImage = Properties.Resources.user1;

            componentes.infoUser = new Label();
            componentes.infoUser.Visible = true;
            componentes.infoUser.Enabled = true;
            componentes.infoUser.BringToFront();
            componentes.infoUser.Text = componentes.emailText.Text.ToString();
            componentes.infoUser.Size = new Size(200, 100);
            componentes.infoUser.Location = new Point(70, 234);
            componentes.infoUser.Parent = componentes.menu;
            componentes.infoUser.Font = new Font("Arial", 10, FontStyle.Bold);

            componentes.logout = new Button();
            componentes.logout.Visible = true;
            componentes.logout.Enabled = true;
            componentes.logout.Size = new Size(60, 28);
            componentes.logout.BringToFront();
            componentes.logout.Parent = componentes.menu;
            componentes.logout.Text = "Logout";
            componentes.logout.BackColor = Color.DarkGray;
            componentes.logout.FlatStyle = FlatStyle.Flat;
            componentes.logout.TextAlign = ContentAlignment.MiddleCenter;
            componentes.logout.Font = new Font("LOUD AND CLEAR PERSONAL USE", 10, FontStyle.Bold);
            componentes.logout.Location = new Point(5, 280);
            componentes.logout.Click += sair;

            componentes.categoryPanel = new FlowLayoutPanel();
            componentes.categoryPanel.Size = new Size(330, 60);
            componentes.categoryPanel.Location = new Point(-4, 145);
            componentes.categoryPanel.Parent = componentes.menu;
            componentes.categoryPanel.Visible = true;
            componentes.categoryPanel.Enabled = true;
            componentes.categoryPanel.BackColor = Color.DarkGray;
            componentes.categoryPanel.AutoScroll = true;
            componentes.categoryPanel.AutoSize = false;
            componentes.categoryPanel.Dock = DockStyle.None;
            // Define a direção do fluxo para esquerda para direita
            componentes.categoryPanel.FlowDirection = FlowDirection.TopDown;

            //botoes do painel de categoria

            componentes.roupa = new Button();
            componentes.roupa.BackColor = Color.Blue;
            componentes.roupa.Visible = true;
            componentes.roupa.Location = new Point(10, 10);
            componentes.roupa.Size = new Size(86, 33);
            componentes.roupa.Text = "Cloths";
            componentes.roupa.Parent = componentes.categoryPanel;
            componentes.roupa.Font = new Font("LOUD AND CLEAR PERSONAL USE", 12, FontStyle.Regular);
            componentes.roupa.BringToFront();
            componentes.roupa.FlatStyle = FlatStyle.System;
            componentes.roupa.FlatAppearance.BorderSize = 0;
            componentes.roupa.Click += filtroRoupa;


            componentes.mobilia = new Button();
            componentes.mobilia.BackColor = Color.Blue;
            componentes.mobilia.Visible = true;
            componentes.mobilia.Location = new Point(100, 10);
            componentes.mobilia.Size = new Size(86, 33);
            componentes.mobilia.Text = "Mobiliary";
            componentes.mobilia.Parent = componentes.categoryPanel;
            componentes.mobilia.Font = new Font("LOUD AND CLEAR PERSONAL USE", 12, FontStyle.Regular);
            componentes.mobilia.BringToFront();
            componentes.categoryPanel.Controls.Add(componentes.mobilia);
            componentes.mobilia.FlatStyle = FlatStyle.System;
            componentes.mobilia.FlatAppearance.BorderSize = 0;
            componentes.mobilia.Click += filtroMobilia;

            componentes.sapatos = new Button();
            componentes.sapatos.BackColor = Color.Blue;
            componentes.sapatos.Visible = true;
            componentes.sapatos.Location = new Point(190, 10);
            componentes.sapatos.Size = new Size(86, 33);
            componentes.sapatos.Text = "Shoes";
            componentes.sapatos.Parent = componentes.categoryPanel;
            componentes.sapatos.Font = new Font("LOUD AND CLEAR PERSONAL USE", 12, FontStyle.Regular);
            componentes.sapatos.BringToFront();
            componentes.categoryPanel.Controls.Add(componentes.sapatos);
            componentes.sapatos.FlatStyle = FlatStyle.System;
            componentes.sapatos.FlatAppearance.BorderSize = 0;
            componentes.sapatos.Click += filtroSapato;

            componentes.comida = new Button();
            componentes.comida.BackColor = Color.Blue;
            componentes.comida.Visible = true;
            componentes.comida.Location = new Point(280, 10);
            componentes.comida.Size = new Size(86, 33);
            componentes.comida.Text = "Food";
            componentes.comida.Parent = componentes.categoryPanel;
            componentes.comida.Font = new Font("LOUD AND CLEAR PERSONAL USE", 12, FontStyle.Regular);
            componentes.comida.BringToFront();
            componentes.categoryPanel.Controls.Add(componentes.comida);
            componentes.comida.FlatStyle = FlatStyle.System;
            componentes.comida.FlatAppearance.BorderSize = 0;
            componentes.comida.Click += filtroComida;

            componentes.banho = new Button();
            componentes.banho.BackColor = Color.Blue;
            componentes.banho.Visible = true;
            componentes.banho.Location = new Point(370, 10);
            componentes.banho.Size = new Size(86, 33);
            componentes.banho.Text = "Bath";
            componentes.banho.Parent = componentes.categoryPanel;
            componentes.banho.Font = new Font("LOUD AND CLEAR PERSONAL USE", 12, FontStyle.Regular);
            componentes.banho.BringToFront();
            componentes.categoryPanel.Controls.Add(componentes.banho);
            componentes.banho.FlatStyle = FlatStyle.System;
            componentes.banho.FlatAppearance.BorderSize = 0;

            componentes.brinquedos = new Button();
            componentes.brinquedos.BackColor = Color.Blue;
            componentes.brinquedos.Visible = true;
            componentes.brinquedos.Location = new Point(460, 10);
            componentes.brinquedos.Size = new Size(86, 33);
            componentes.brinquedos.Text = "Toys";
            componentes.brinquedos.Parent = componentes.categoryPanel;
            componentes.brinquedos.Font = new Font("LOUD AND CLEAR PERSONAL USE", 12, FontStyle.Regular);
            componentes.brinquedos.BringToFront();
            componentes.categoryPanel.Controls.Add(componentes.brinquedos);
            componentes.brinquedos.FlatStyle = FlatStyle.System;
            componentes.brinquedos.FlatAppearance.BorderSize = 0;

            //

            componentes.suport = new Button();
            componentes.suport.Visible = true;
            componentes.suport.Location = new Point(-4, 95);
            componentes.suport.Size = new Size(340, 50);
            componentes.suport.Text = "Category";
            componentes.suport.Font = new Font("LOUD AND CLEAR PERSONAL USE", 30, FontStyle.Regular);
            componentes.suport.ForeColor = Color.Black;
            componentes.suport.BackColor = Color.White;
            componentes.suport.Parent = componentes.menu;
            componentes.suport.FlatStyle = FlatStyle.Flat;
            componentes.suport.TextAlign = ContentAlignment.BottomLeft;

            componentes.subPanelTitleProducts = new Label();
            componentes.subPanelTitleProducts.Font = new Font("LOUD AND CLEAR PERSONAL USE", 30, FontStyle.Regular);
            componentes.subPanelTitleProducts.Parent = componentes.produtoTitle;
            componentes.subPanelTitleProducts.Visible = true;
            componentes.subPanelTitleProducts.Enabled = true;
            componentes.subPanelTitleProducts.Text = "PRODUCTS";
            componentes.subPanelTitleProducts.ForeColor = Color.Black;
            componentes.subPanelTitleProducts.Size = new Size(500, 500);
            componentes.subPanelTitleProducts.Location = new Point(0, 0);

            componentes.socialButtoFacebook = new Button();
            componentes.socialButtoFacebook.BackColor = Color.Blue;
            componentes.socialButtoFacebook.Visible = true;
            componentes.socialButtoFacebook.Location = new Point(10, 900);
            componentes.socialButtoFacebook.Size = new Size(86, 33);
            componentes.socialButtoFacebook.Text = "Facebook";
            componentes.socialButtoFacebook.Parent = componentes.menu;
            componentes.socialButtoFacebook.Font = new Font("LOUD AND CLEAR PERSONAL USE", 12, FontStyle.Regular);
            componentes.socialButtoFacebook.BringToFront();
            componentes.socialButtoFacebook.FlatStyle = FlatStyle.System;
            componentes.socialButtoFacebook.FlatAppearance.BorderSize = 0;


            componentes.socialButtoInstagram = new Button();
            componentes.socialButtoInstagram.BackColor = Color.Blue;
            componentes.socialButtoInstagram.Visible = true;
            componentes.socialButtoInstagram.Location = new Point(100, 900);
            componentes.socialButtoInstagram.Size = new Size(86, 33);
            componentes.socialButtoInstagram.Text = "Instagram";
            componentes.socialButtoInstagram.Parent = componentes.menu;
            componentes.socialButtoInstagram.Font = new Font("LOUD AND CLEAR PERSONAL USE", 12, FontStyle.Regular);
            componentes.socialButtoInstagram.BringToFront();
            componentes.socialButtoInstagram.FlatStyle = FlatStyle.System;
            componentes.socialButtoInstagram.FlatAppearance.BorderSize = 0;

            componentes.socialButtoTwitter = new Button();
            componentes.socialButtoTwitter.BackColor = Color.Blue;
            componentes.socialButtoTwitter.Visible = true;
            componentes.socialButtoTwitter.Location = new Point(190, 900);
            componentes.socialButtoTwitter.Size = new Size(86, 33);
            componentes.socialButtoTwitter.Text = "Twitter";
            componentes.socialButtoTwitter.Parent = componentes.menu;
            componentes.socialButtoTwitter.Font = new Font("LOUD AND CLEAR PERSONAL USE", 12, FontStyle.Regular);
            componentes.socialButtoTwitter.BringToFront();
            componentes.socialButtoTwitter.FlatStyle = FlatStyle.System;
            componentes.socialButtoTwitter.FlatAppearance.BorderSize = 0;

            //inventário de produtos

            //slot 1
            componentes.SlotProduto1 = new Panel();
            componentes.SlotProduto1.Location = new Point(10, 160);
            componentes.SlotProduto1.Size = new Size(300, 400);
            componentes.SlotProduto1.BackColor = Color.Orange;
            componentes.SlotProduto1.Visible = true;
            componentes.SlotProduto1.Enabled = true;


            componentes.produto1 = new Panel();
            componentes.produto1.Location = new Point(0, 0);
            componentes.produto1.Size = new Size(300, 250);
            componentes.produto1.BringToFront();
            componentes.produto1.Parent = componentes.SlotProduto1;
            componentes.produto1.Visible = true;
            componentes.produto1.Enabled = true;

            componentes.infoProduto1 = new Label();
            componentes.infoProduto1.Visible = true;
            componentes.infoProduto1.Enabled = true;
            componentes.infoProduto1.Size = new Size(250, 240);
            componentes.infoProduto1.Parent = componentes.SlotProduto1;
            componentes.infoProduto1.Location = new Point(5, 260);
            componentes.infoProduto1.ForeColor = Color.Black;
            componentes.infoProduto1.BackColor = Color.Transparent;
            componentes.infoProduto1.Font = new Font("Arial", 12, FontStyle.Bold);
            componentes.infoProduto1.BringToFront();


            //slot2
            componentes.SlotProduto2 = new Panel();
            componentes.SlotProduto2.Location = new Point(350, 160);
            componentes.SlotProduto2.Size = new Size(300, 400);
            componentes.SlotProduto2.BackColor = Color.Orange;
            componentes.SlotProduto2.Visible = true;
            componentes.SlotProduto2.Enabled = true;


            componentes.produto2 = new Panel();
            componentes.produto2.Location = new Point(0, 0);
            componentes.produto2.Size = new Size(300, 250);
            componentes.produto2.BringToFront();
            componentes.produto2.Parent = componentes.SlotProduto2;
            componentes.produto2.Visible = true;
            componentes.produto2.Enabled = true;

            componentes.infoProduto2 = new Label();
            componentes.infoProduto2.Visible = true;
            componentes.infoProduto2.Enabled = true;
            componentes.infoProduto2.Size = new Size(250, 240);
            componentes.infoProduto2.Parent = componentes.SlotProduto2;
            componentes.infoProduto2.Location = new Point(5, 260);
            componentes.infoProduto2.ForeColor = Color.Black;
            componentes.infoProduto2.BackColor = Color.Transparent;
            componentes.infoProduto2.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto2.BringToFront();

            //slot3
            componentes.SlotProduto3 = new Panel();
            componentes.SlotProduto3.Location = new Point(701, 160);
            componentes.SlotProduto3.Size = new Size(300, 400);
            componentes.SlotProduto3.BackColor = Color.Orange;
            componentes.SlotProduto3.Visible = true;
            componentes.SlotProduto3.Enabled = true;

            componentes.produto3 = new Panel();
            componentes.produto3.Location = new Point(0, 0);
            componentes.produto3.Size = new Size(300, 250);
            componentes.produto3.BringToFront();
            componentes.produto3.Parent = componentes.SlotProduto3;
            componentes.produto3.Visible = true;
            componentes.produto3.Enabled = true;

            componentes.infoProduto3 = new Label();
            componentes.infoProduto3.Visible = true;
            componentes.infoProduto3.Enabled = true;
            componentes.infoProduto3.Size = new Size(250, 240);
            componentes.infoProduto3.Parent = componentes.SlotProduto3;
            componentes.infoProduto3.Location = new Point(5, 260);
            componentes.infoProduto3.ForeColor = Color.Black;
            componentes.infoProduto3.BackColor = Color.Transparent;
            componentes.infoProduto3.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto3.BringToFront();

            //slot4
            componentes.SlotProduto4 = new Panel();
            componentes.SlotProduto4.Location = new Point(1052, 160);
            componentes.SlotProduto4.Size = new Size(300, 400);
            componentes.SlotProduto4.BackColor = Color.Orange;
            componentes.SlotProduto4.Visible = true;
            componentes.SlotProduto4.Enabled = true;

            componentes.produto4 = new Panel();
            componentes.produto4.Location = new Point(0, 0);
            componentes.produto4.Size = new Size(300, 250);
            componentes.produto4.BringToFront();
            componentes.produto4.Parent = componentes.SlotProduto4;
            componentes.produto4.Visible = true;
            componentes.produto4.Enabled = true;

            componentes.infoProduto4 = new Label();
            componentes.infoProduto4.Visible = true;
            componentes.infoProduto4.Enabled = true;
            componentes.infoProduto4.Size = new Size(250, 240);
            componentes.infoProduto4.Parent = componentes.SlotProduto4;
            componentes.infoProduto4.Location = new Point(5, 260);
            componentes.infoProduto4.ForeColor = Color.Black;
            componentes.infoProduto4.BackColor = Color.Transparent;
            componentes.infoProduto4.Font = new Font("Arial", 10, FontStyle.Bold);




            //slot5
            componentes.SlotProduto5 = new Panel();
            componentes.SlotProduto5.Location = new Point(1403, 160);
            componentes.SlotProduto5.Size = new Size(300, 400);
            componentes.SlotProduto5.BackColor = Color.Orange;
            componentes.SlotProduto5.Visible = true;
            componentes.SlotProduto5.BringToFront();
            componentes.SlotProduto5.Enabled = true;

            componentes.produto5 = new Panel();
            componentes.produto5.Location = new Point(0, 0);
            componentes.produto5.Size = new Size(300, 250);
            componentes.produto5.BringToFront();
            componentes.produto5.Parent = componentes.SlotProduto5;
            componentes.produto5.Visible = true;
            componentes.produto5.Enabled = true;

            componentes.infoProduto5 = new Label();
            componentes.infoProduto5.Visible = true;
            componentes.infoProduto5.Enabled = true;
            componentes.infoProduto5.Size = new Size(250, 240);
            componentes.infoProduto5.Parent = componentes.SlotProduto5;
            componentes.infoProduto5.Location = new Point(5, 260);
            componentes.infoProduto5.ForeColor = Color.Black;
            componentes.infoProduto5.BackColor = Color.Transparent;
            componentes.infoProduto5.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto5.BringToFront();

            //slot6
            componentes.SlotProduto6 = new Panel();
            componentes.SlotProduto6.Location = new Point(1754, 160);
            componentes.SlotProduto6.Size = new Size(300, 400);
            componentes.SlotProduto6.BackColor = Color.Orange;
            componentes.SlotProduto6.Visible = true;
            componentes.SlotProduto6.BringToFront();
            componentes.SlotProduto6.Enabled = true;

            componentes.produto6 = new Panel();
            componentes.produto6.Location = new Point(0, 0);
            componentes.produto6.Size = new Size(300, 250);
            componentes.produto6.BringToFront();
            componentes.produto6.Parent = componentes.SlotProduto6;
            componentes.produto6.Visible = true;
            componentes.produto6.Enabled = true;

            componentes.infoProduto6 = new Label();
            componentes.infoProduto6.Visible = true;
            componentes.infoProduto6.Enabled = true;
            componentes.infoProduto6.Size = new Size(250, 240);
            componentes.infoProduto6.Parent = componentes.SlotProduto6;
            componentes.infoProduto6.Location = new Point(5, 260);
            componentes.infoProduto6.ForeColor = Color.Black;
            componentes.infoProduto6.BackColor = Color.Transparent;
            componentes.infoProduto6.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto6.BringToFront();

            //slot7
            componentes.SlotProduto7 = new Panel();
            componentes.SlotProduto7.Location = new Point(1754, 160);
            componentes.SlotProduto7.Size = new Size(300, 400);
            componentes.SlotProduto7.BackColor = Color.Orange;
            componentes.SlotProduto7.Visible = true;
            componentes.SlotProduto7.BringToFront();
            componentes.SlotProduto7.Enabled = true;
            


            componentes.produto7 = new Panel();
            componentes.produto7.Location = new Point(0, 0);
            componentes.produto7.Size = new Size(300, 250);
            componentes.produto7.BringToFront();
            componentes.produto7.Parent = componentes.SlotProduto7;
            componentes.produto7.Visible = true;
            componentes.produto7.Enabled = true;

            componentes.infoProduto7 = new Label();
            componentes.infoProduto7.Visible = true;
            componentes.infoProduto7.Enabled = true;
            componentes.infoProduto7.Size = new Size(250, 240);
            componentes.infoProduto7.Parent = componentes.SlotProduto7;
            componentes.infoProduto7.Location = new Point(5, 260);
            componentes.infoProduto7.ForeColor = Color.Black;
            componentes.infoProduto7.BackColor = Color.Transparent;
            componentes.infoProduto7.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto7.BringToFront();

            //slot8
            componentes.SlotProduto8 = new Panel();
            componentes.SlotProduto8.Location = new Point(1754, 160);
            componentes.SlotProduto8.Size = new Size(300, 400);
            componentes.SlotProduto8.BackColor = Color.Orange;
            componentes.SlotProduto8.Visible = true;
            componentes.SlotProduto8.BringToFront();
            componentes.SlotProduto8.Enabled = true;



            componentes.produto8 = new Panel();
            componentes.produto8.Location = new Point(0, 0);
            componentes.produto8.Size = new Size(300, 250);
            componentes.produto8.BringToFront();
            componentes.produto8.Parent = componentes.SlotProduto8;
            componentes.produto8.Visible = true;
            componentes.produto8.Enabled = true;

            componentes.infoProduto8 = new Label();
            componentes.infoProduto8.Visible = true;
            componentes.infoProduto8.Enabled = true;
            componentes.infoProduto8.Size = new Size(250, 240);
            componentes.infoProduto8.Parent = componentes.SlotProduto8;
            componentes.infoProduto8.Location = new Point(5, 260);
            componentes.infoProduto8.ForeColor = Color.Black;
            componentes.infoProduto8.BackColor = Color.Transparent;
            componentes.infoProduto8.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto8.BringToFront();


            //slot9
            componentes.SlotProduto9 = new Panel();
            componentes.SlotProduto9.Location = new Point(1754, 160);
            componentes.SlotProduto9.Size = new Size(300, 400);
            componentes.SlotProduto9.BackColor = Color.Orange;
            componentes.SlotProduto9.Visible = true;
            componentes.SlotProduto9.BringToFront();
            componentes.SlotProduto9.Enabled = true;



            componentes.produto9 = new Panel();
            componentes.produto9.Location = new Point(0, 0);
            componentes.produto9.Size = new Size(300, 250);
            componentes.produto9.BringToFront();
            componentes.produto9.Parent = componentes.SlotProduto9;
            componentes.produto9.Visible = true;
            componentes.produto9.Enabled = true;

            componentes.infoProduto9 = new Label();
            componentes.infoProduto9.Visible = true;
            componentes.infoProduto9.Enabled = true;
            componentes.infoProduto9.Size = new Size(250, 240);
            componentes.infoProduto9.Parent = componentes.SlotProduto9;
            componentes.infoProduto9.Location = new Point(5, 260);
            componentes.infoProduto9.ForeColor = Color.Black;
            componentes.infoProduto9.BackColor = Color.Transparent;
            componentes.infoProduto9.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto9.BringToFront();

            //slot10
            componentes.SlotProduto10 = new Panel();
            componentes.SlotProduto10.Location = new Point(1754, 160);
            componentes.SlotProduto10.Size = new Size(300, 400);
            componentes.SlotProduto10.BackColor = Color.Orange;
            componentes.SlotProduto10.Visible = true;
            componentes.SlotProduto10.BringToFront();
            componentes.SlotProduto10.Enabled = true;



            componentes.produto10 = new Panel();
            componentes.produto10.Location = new Point(0, 0);
            componentes.produto10.Size = new Size(300, 250);
            componentes.produto10.BringToFront();
            componentes.produto10.Parent = componentes.SlotProduto10;
            componentes.produto10.Visible = true;
            componentes.produto10.Enabled = true;

            componentes.infoProduto10 = new Label();
            componentes.infoProduto10.Visible = true;
            componentes.infoProduto10.Enabled = true;
            componentes.infoProduto10.Size = new Size(250, 240);
            componentes.infoProduto10.Parent = componentes.SlotProduto10;
            componentes.infoProduto10.Location = new Point(5, 260);
            componentes.infoProduto10.ForeColor = Color.Black;
            componentes.infoProduto10.BackColor = Color.Transparent;
            componentes.infoProduto10.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto10.BringToFront();

            //slot11
            componentes.SlotProduto11 = new Panel();
            componentes.SlotProduto11.Location = new Point(1754, 160);
            componentes.SlotProduto11.Size = new Size(300, 400);
            componentes.SlotProduto11.BackColor = Color.Orange;
            componentes.SlotProduto11.Visible = true;
            componentes.SlotProduto11.BringToFront();
            componentes.SlotProduto11.Enabled = true;



            componentes.produto11 = new Panel();
            componentes.produto11.Location = new Point(0, 0);
            componentes.produto11.Size = new Size(300, 250);
            componentes.produto11.BringToFront();
            componentes.produto11.Parent = componentes.SlotProduto11;
            componentes.produto11.Visible = true;
            componentes.produto11.Enabled = true;

            componentes.infoProduto11 = new Label();
            componentes.infoProduto11.Visible = true;
            componentes.infoProduto11.Enabled = true;
            componentes.infoProduto11.Size = new Size(250, 240);
            componentes.infoProduto11.Parent = componentes.SlotProduto11;
            componentes.infoProduto11.Location = new Point(5, 260);
            componentes.infoProduto11.ForeColor = Color.Black;
            componentes.infoProduto11.BackColor = Color.Transparent;
            componentes.infoProduto11.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto11.BringToFront();

            //slot12
            componentes.SlotProduto12 = new Panel();
            componentes.SlotProduto12.Location = new Point(1754, 160);
            componentes.SlotProduto12.Size = new Size(300, 400);
            componentes.SlotProduto12.BackColor = Color.Orange;
            componentes.SlotProduto12.Visible = true;
            componentes.SlotProduto12.BringToFront();
            componentes.SlotProduto12.Enabled = true;



            componentes.produto12 = new Panel();
            componentes.produto12.Location = new Point(0, 0);
            componentes.produto12.Size = new Size(300, 250);
            componentes.produto12.BringToFront();
            componentes.produto12.Parent = componentes.SlotProduto12;
            componentes.produto12.Visible = true;
            componentes.produto12.Enabled = true;

            componentes.infoProduto12 = new Label();
            componentes.infoProduto12.Visible = true;
            componentes.infoProduto12.Enabled = true;
            componentes.infoProduto12.Size = new Size(250, 240);
            componentes.infoProduto12.Parent = componentes.SlotProduto12;
            componentes.infoProduto12.Location = new Point(5, 260);
            componentes.infoProduto12.ForeColor = Color.Black;
            componentes.infoProduto12.BackColor = Color.Transparent;
            componentes.infoProduto12.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto12.BringToFront();

            //slot13
            componentes.SlotProduto13 = new Panel();
            componentes.SlotProduto13.Location = new Point(1754, 160);
            componentes.SlotProduto13.Size = new Size(300, 400);
            componentes.SlotProduto13.BackColor = Color.Orange;
            componentes.SlotProduto13.Visible = true;
            componentes.SlotProduto13.BringToFront();
            componentes.SlotProduto13.Enabled = true;



            componentes.produto13 = new Panel();
            componentes.produto13.Location = new Point(0, 0);
            componentes.produto13.Size = new Size(300, 250);
            componentes.produto13.BringToFront();
            componentes.produto13.Parent = componentes.SlotProduto13;
            componentes.produto13.Visible = true;
            componentes.produto13.Enabled = true;

            componentes.infoProduto13 = new Label();
            componentes.infoProduto13.Visible = true;
            componentes.infoProduto13.Enabled = true;
            componentes.infoProduto13.Size = new Size(250, 240);
            componentes.infoProduto13.Parent = componentes.SlotProduto13;
            componentes.infoProduto13.Location = new Point(5, 260);
            componentes.infoProduto13.ForeColor = Color.Black;
            componentes.infoProduto13.BackColor = Color.Transparent;
            componentes.infoProduto13.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto13.BringToFront();



            //slot14
            componentes.SlotProduto14 = new Panel();
            componentes.SlotProduto14.Location = new Point(1754, 160);
            componentes.SlotProduto14.Size = new Size(300, 400);
            componentes.SlotProduto14.BackColor = Color.Orange;
            componentes.SlotProduto14.Visible = true;
            componentes.SlotProduto14.BringToFront();
            componentes.SlotProduto14.Enabled = true;



            componentes.produto14 = new Panel();
            componentes.produto14.Location = new Point(0, 0);
            componentes.produto14.Size = new Size(300, 250);
            componentes.produto14.BringToFront();
            componentes.produto14.Parent = componentes.SlotProduto14;
            componentes.produto14.Visible = true;
            componentes.produto14.Enabled = true;

            componentes.infoProduto14 = new Label();
            componentes.infoProduto14.Visible = true;
            componentes.infoProduto14.Enabled = true;
            componentes.infoProduto14.Size = new Size(250, 240);
            componentes.infoProduto14.Parent = componentes.SlotProduto14;
            componentes.infoProduto14.Location = new Point(5, 260);
            componentes.infoProduto14.ForeColor = Color.Black;
            componentes.infoProduto14.BackColor = Color.Transparent;
            componentes.infoProduto14.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto14.BringToFront();

            //slot15
            componentes.SlotProduto15 = new Panel();
            componentes.SlotProduto15.Location = new Point(1754, 160);
            componentes.SlotProduto15.Size = new Size(300, 400);
            componentes.SlotProduto15.BackColor = Color.Orange;
            componentes.SlotProduto15.Visible = true;
            componentes.SlotProduto15.BringToFront();
            componentes.SlotProduto15.Enabled = true;



            componentes.produto15 = new Panel();
            componentes.produto15.Location = new Point(0, 0);
            componentes.produto15.Size = new Size(300, 250);
            componentes.produto15.BringToFront();
            componentes.produto15.Parent = componentes.SlotProduto15;
            componentes.produto15.Visible = true;
            componentes.produto15.Enabled = true;

            componentes.infoProduto15 = new Label();
            componentes.infoProduto15.Visible = true;
            componentes.infoProduto15.Enabled = true;
            componentes.infoProduto15.Size = new Size(250, 240);
            componentes.infoProduto15.Parent = componentes.SlotProduto15;
            componentes.infoProduto15.Location = new Point(5, 260);
            componentes.infoProduto15.ForeColor = Color.Black;
            componentes.infoProduto15.BackColor = Color.Transparent;
            componentes.infoProduto15.Font = new Font("Arial", 10, FontStyle.Bold);
            componentes.infoProduto15.BringToFront();


            componentes.layoutRoll = new FlowLayoutPanel();
            componentes.layoutRoll.Size = new Size(1600, 1000);
            componentes.layoutRoll.Location = new Point(5, 160);
            componentes.layoutRoll.Parent = componentes.telaPrincipal;
            componentes.layoutRoll.Visible = true;
            componentes.layoutRoll.Enabled = true;
            componentes.layoutRoll.BringToFront();
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto1);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto2);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto3);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto4);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto5);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto6);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto7);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto8);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto9);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto10);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto11);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto12);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto13);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto14);
            componentes.layoutRoll.Controls.Add(componentes.SlotProduto15);
            componentes.layoutRoll.AutoScroll = true;
            componentes.layoutRoll.AutoSize = false;
            componentes.layoutRoll.Dock = DockStyle.Right;
            // Define a direção do fluxo para esquerda para direita
            componentes.layoutRoll.FlowDirection = FlowDirection.LeftToRight;
          
            // Define para o conteúdo não quebrar em várias linhas ou colunas
            componentes.layoutRoll.WrapContents = true;

            consult();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static void sair(object sender, EventArgs e)
        {
            componentes.telaPrincipal.Visible = false;
            componentes.loginWindow.Visible = true;
            componentes.loginWindow.Enabled = true;
        }
    }
}

    //apache do xamp conectado a porta 8080 e o mysql na pora 3306
    class componentes
    {
    //menu scroll

    //mobilia
    //roupa
    //cosinha
    //brinquedo
    //banho
    //sapatos
    public static FlowLayoutPanel layoutRoll;
    //verificador
    public static int idDesejado;
    //interface produtos
    public static Button logoutLogin;

    public static FlowLayoutPanel categoryPanel;
    public static Button suport;
    public static Panel produto1;
    public static Panel userIcon;
    public static Panel SlotProduto1;
    public static Label infoProduto1;

    public static Panel produto2;
    public static Panel SlotProduto2;
    public static Label infoProduto2;

    public static Panel produto3;
    public static Panel SlotProduto3;
    public static Label infoProduto3;

    public static Panel produto4;
    public static Panel SlotProduto4;
    public static Label infoProduto4;

    public static Panel produto5;
    public static Panel SlotProduto5;
    public static Label infoProduto5;

    public static Panel produto6;
    public static Panel SlotProduto6;
    public static Label infoProduto6;

    public static Panel produto7;
    public static Panel SlotProduto7;
    public static Label infoProduto7;

    public static Panel produto8;
    public static Panel SlotProduto8;
    public static Label infoProduto8;

    public static Panel produto9;
    public static Panel SlotProduto9;
    public static Label infoProduto9;

    public static Panel produto10;
    public static Panel SlotProduto10;
    public static Label infoProduto10;

    public static Panel produto11;
    public static Panel SlotProduto11;
    public static Label infoProduto11;

    public static Panel produto12;
    public static Panel SlotProduto12;
    public static Label infoProduto12;

    public static Panel produto13;
    public static Panel SlotProduto13;
    public static Label infoProduto13;

    public static Panel produto14;
    public static Panel SlotProduto14;
    public static Label infoProduto14;

    public static Panel produto15;
    public static Panel SlotProduto15;
    public static Label infoProduto15;

    public static Label infoUser;

    public static Label titleProducts;
    public static Label subPanelTitleProducts;
    public static Form telaPrincipal;
    public static Panel topPanel;
    public static Panel produtoTitle;
    public static Panel menu;
    public static Button socialButtoFacebook;
    public static Button socialButtoTwitter;
    public static Button socialButtoInstagram;
    public static Button logout;

    public static Button comida;
    public static Button banho;
    public static Button brinquedos;
    public static Button sapatos;
    public static Button cozinha;
    public static Button mobilia;
    public static Button roupa;
    //interface login 
    public static Form loginWindow;
    public static Label title;
    public static TextBox emailText;
    public static TextBox passwordText;
    public static Label titleEmail;
    public static Label titleSenha;
    public static Button cadastro;
    public static Button entrar;




        public static Form cadastroDisplay;
        public static TextBox userBox;
        public static TextBox emailBox;
        public static TextBox senhaBox;
        public static TextBox numeroBox;


        public static string userData;
        public static string emailData;
        public static string senhaData;
        public static string numeroData;

        public static Label userName;
        public static Label emailName;
        public static Label senhaName;
        public static Label numeroName;
        public static Label tituloWindowCadastro;
        public static Button finalizarCadastro;
        public static Button fecharCadastro;

    }

    public class metodos
    {
    }

