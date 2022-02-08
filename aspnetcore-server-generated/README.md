Make sure the Docker agent runs within the docker container on port 5000!

Running without Docker:
- Just click Run in Visual Studio

Running with Docker:
- `cd` into the `aspnetcore-server/src/IO.Swagger` directory
- `docker build -t MyBombersauceAgentInAspNetCore .`
- `docker run -p 12345:5000 -it MyBombersauceAgentInAspNetCore`
- Now you can see the Swagger page at http://localhost:12345/swagger .
