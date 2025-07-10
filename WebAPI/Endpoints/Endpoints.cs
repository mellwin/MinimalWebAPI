using WebAPI.Services;

namespace WebAPI.Endpoints
{
    public static class Endpoints
    {
        public static void MapEndpoints(this WebApplication app)
        {
            app.MapGet("/accounts", async (IAccountService accountService) => 
            {
                //any logic
                var accounts = await accountService.GetAllAsync();
                return Results.Ok("accounts");
            });
        }
    }
}