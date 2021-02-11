using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CineManager.Domain
{
    /// <summary>
    ///     Classe representativa com os dados da sala
    /// </summary>
    public class Room
    {
        /// <summary>
        ///     Identificador único da sala
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        ///     Indexador da sala
        /// </summary>
        [BsonElement(elementName: "room_id")]
        public int RoomId { get; set; }

        /// <summary>
        ///     Nome da sala
        /// </summary>
        [BsonElement(elementName: "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Quantodade de assentos da sala
        /// </summary>
        [BsonElement(elementName: "number_seats")]
        public int NumberOfSeats { get; set; }
    }
}
