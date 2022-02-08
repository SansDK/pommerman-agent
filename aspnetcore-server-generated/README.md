Running without Docker:
- Just click Run in Visual Studio

Running with Docker:
- `cd` into the aspnetcore-server directory
- `docker build -t MyBombersauceAgentInAspNetCore .`
- `docker run -p 12345:80 -it MyBombersauceAgentInAspNetCore`
- Now you can see the Swagger page at http://localhost:12345/swagger .
