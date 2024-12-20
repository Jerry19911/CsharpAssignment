using System;

namespace Business.Helpers
{
    public static class GuidGenerator
    {
        public static string GenerateUniqueId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
