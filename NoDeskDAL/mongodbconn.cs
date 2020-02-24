using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace NoDeskDAL
{
    public class mongodbconn
    {
        static void dbconn()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://devUser:nosqlnodesk@nosqlcluster-afxdw.mongodb.net/test?retryWrites=true&w=majority");

            var database = dbClient.GetDatabase("sample_training");
            var collection = database.GetCollection<BsonDocument>("grades");

        }
    }
}
