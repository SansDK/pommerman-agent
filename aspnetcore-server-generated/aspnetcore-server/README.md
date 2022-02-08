# IO.Swagger - ASP.NET Core 3.0 Server

API for an agent of the Bombersauce AI-hackathon.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```