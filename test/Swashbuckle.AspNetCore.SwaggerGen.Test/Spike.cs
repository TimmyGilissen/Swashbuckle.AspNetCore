using System;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;

namespace Swashbuckle.AspNetCore.SwaggerGen.Test
{
    public class Spike
    {
        [Fact]
        public void Test()
        {
            var value = AnnotatedEnum.Bar;
            var jsonString = JsonSerializer.Serialize(value, new JsonSerializerOptions { });
            throw new Exception(jsonString);
        }
    }

    internal class Thing
    {
        public string Property1 { get; set; }

        public string Property2 { get; private set; } = "bar";
    }
}
