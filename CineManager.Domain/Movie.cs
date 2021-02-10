using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CineManager.Domain
{
    /// <summary>
    ///     Classe representativa com os dados do filme
    /// </summary>
    [BsonDiscriminator()]
    public class Movie
    {
        /// <summary>
        ///     Identificador único do filme
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        ///     Indexador do filme
        /// </summary>
        [BsonElement(elementName: "movie_id")]
        public int MovieId { get; set; }

        /// <summary>
        ///     Imagem (Poster ou banner) do filme
        /// </summary>
        [BsonElement(elementName: "image")]
        public string Image { get; set; }

        /// <summary>
        ///     Título do filme
        /// </summary>
        [BsonElement(elementName: "title")]
        public string Title { get; set; }

        /// <summary>
        ///     Descrição do filme
        /// </summary>
        [BsonElement(elementName: "description")]
        public string Description { get; set; }

        /// <summary>
        ///     Duração do filme em minutos
        /// </summary>
        [BsonElement(elementName: "duration")]
        public int Duration { get; set; }
    }
}
