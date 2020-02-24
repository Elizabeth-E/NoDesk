using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace NoDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://devUser:nosqlnodesk@nosqlcluster-afxdw.mongodb.net/test?retryWrites=true&w=majority");

            var database = dbClient.GetDatabase("TopDesk");
            var collection = database.GetCollection<BsonDocument>("inquiry");
            var documents = collection.Find(new BsonDocument()).ToList();

            var dbList = dbClient.ListDatabases().ToList();

            dbtext.Text = "The list of databases on this server is: ";
            foreach (var db in documents)
            {
                dbtext.Text += db.ToString();
            }
        }

    }
}
