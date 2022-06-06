using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Serializers;
using Rest.TaskCardModule.Core.Entities;

namespace Rest.TaskCardModule.Infrastructure.Persistence.Mappings;

public static class MongoDbMapping
{
    public static void Map()
    {
        BsonClassMap.RegisterClassMap<TaskComment>(cm =>
        {
            cm.AutoMap();
            cm.SetIgnoreExtraElements(true);
        });

        BsonClassMap.RegisterClassMap<TaskCard>(cm =>
        {
            cm.AutoMap();
            cm.MapIdMember(e => e.Id)
              .SetIdGenerator(StringObjectIdGenerator.Instance)
              .SetSerializer(new StringSerializer(BsonType.ObjectId));
            cm.SetIgnoreExtraElements(true);
        });
    }
}
