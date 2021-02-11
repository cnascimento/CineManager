using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CineManager.Domain
{
    /// <summary>
    ///     Classe representativa com os dados do usuário
    /// </summary>
    public class User
    {
        /// <summary>
        ///     Identificador único do usuário
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        ///     Indexador do usuário
        /// </summary>
        [BsonElement(elementName: "user_id")]
        public int UserId { get; set; }

        /// <summary>
        ///     Nome do usuário
        /// </summary>
        [BsonElement(elementName: "name")]
        public string Name { get; set; }

        /// <summary>
        ///     E-mail do usuário, é utilizado com o login
        /// </summary>
        [BsonElement(elementName: "email")]
        public string Email { get; set; }

        /// <summary>
        ///     Senha do usuário
        /// </summary>
        [BsonElement(elementName: "password")]
        public string Password { get; set; }
    }
}
