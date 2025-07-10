namespace WebAPI.Endpoints
{
    public static class Endpoints
    {
        public static void MapEndpoints(this WebApplication app)
        {
            app.MapGet("/accounts", async () => 
            {
                //any logic
                return Results.Ok("List of accounts");
            });
        }
    }
}