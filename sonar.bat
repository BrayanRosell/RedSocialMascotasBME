dotnet sonarscanner begin /k:"RedSocialMascotasBME" /d:sonar.host.url="https://sonar-test.bit2bittest.com" /d:sonar.login="350eb370169731ef2fd4c7a511a687636b2c9b9e"
dotnet build "red_social_mascotas.sln"
dotnet sonarscanner end /d:sonar.login="350eb370169731ef2fd4c7a511a687636b2c9b9e"