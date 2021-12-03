# How to run with Visual Studio

1. Clone de PommermanAgentDotNet repo

2. Open de solution in Visual Studio

3. Klik op start

# How to run without Visual Studio

1. Clone de PommermanAgentDotNet repo

2. Open een console en cd in de PommermanAgentDotNet map die je net hebt gecloned

3. Build de docker image. Replace de paden met de goede locatie op jouw machine:
`docker build -t pommermanagentdotnet .`

4. Run de docker image.
`docker run -e "ASPNETCORE_ENVIRONMENT=Development" -P --name PommermanAgentDotNet pommermanagentdotnet`

5. Run `docker port PommermanAgentDotNet` om te zien naar welke port hij gemapt is

6. Ga naar http://localhost:JOUWPORT/swagger
