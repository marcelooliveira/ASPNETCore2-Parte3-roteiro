Suporte para ASP.NET Core Identity foi adicionado ao seu projeto
- O código para adicionar identidade ao seu projeto foi gerado em Áreas / Identidade.

A configuração dos serviços relacionados à IDENTIDADE pode ser encontrada no arquivo Areas / Identity / IdentityHostingStartup.cs.

Se seu aplicativo foi configurado anteriormente para usar IDENTITY, você deve remover a chamada para o método AddIdentity do seu método ConfigureServices.

A interface do usuário gerada requer suporte para arquivos estáticos. Para adicionar arquivos estáticos ao seu aplicativo:
1. Chame app.UseStaticFiles () do seu método Configure

Para usar o ASP.NET Core Identity, você também precisa ativar a autenticação. Para autenticação no seu aplicativo:
1. Chame app.UseAuthentication () do seu método Configure (depois de arquivos estáticos)

A interface do usuário gerada requer o MVC. Para adicionar o MVC ao seu aplicativo:
1. Chamar services.AddMvc () do seu método ConfigureServices
2. Chame app.UseMvc () do seu método Configure (depois da autenticação)

O código do banco de dados gerado requer Migrações Principais do Entity Framework. Execute os seguintes comandos:
1. dotnet ef migations add CreateIdentitySchema
2. atualização do banco de dados dotnet ef
 Ou no Console do Gerenciador de Pacotes do Visual Studio:
1. Add-Migration CreateIdentitySchema -Context AppIdentityContext
2. Update-Database -Context AppIdentityContext

Aplicativos que usam o ASP.NET Core Identity também devem usar HTTPS. Para ativar o HTTPS, consulte https://go.microsoft.com/fwlink/?linkid=848054.