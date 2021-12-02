# How to run with Visual Studio

1. Clone de PommermanAgentDotNet repo

2. Open de solution in Visual Studio

3. Klik op start

# How to run without Visual Studio

1. Clone de PommermanAgentDotNet repo

2. Open een console en cd in de PommermanAgentDotNet map die je net hebt gecloned

3. Build de docker image. Replace de paden met de goede locatie op jouw machine:
`docker build -f "C:\Users\ReinierJ\source\repos\PommermanAgentDotNet\Dockerfile" --force-rm -t pommermanagentdotnet "C:\Users\ReinierJ\source\repos\PommermanAgentDotNet"`

4. Run de docker image.
`docker run -dt -e "ASPNETCORE_ENVIRONMENT=Development" -P --name PommermanAgentDotNet --entrypoint tail pommermanagentdotnet -f /dev/null`

5. Start de webserver in de docker image
`docker exec -i -w "/app" PommermanAgentDotNet sh -c "dotnet PommermanAgentDotNet.dll"`