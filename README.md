# FaturamentoDistribuidoraJSON

# Faturamento Distribuidora

Esse código desenvolvido em C#, tem a funcionalidade de ler um arquivo JSON que possui as informações de faturamento do dia de uma distribuidora, e do dia. Assim, consultando o menor valor do mês, maior valor do mês e os números de dias que são maiores que a média!

## Como Executar

### Pré-requisitos

Certifique-se de ter as seguintes ferramentas instaladas:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) ou superior
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) (ou Visual Studio Code com o plugin C#)

### Executando

Certifique-se que o arquivo json está parametrizado em 'Copiar para Diretório de Saída' como 'Copiar se for mais novo' ou 'Copiar Sempre'

![image](https://github.com/user-attachments/assets/79556709-efb2-4c22-a7a2-c5bf33c11e77)

![image](https://github.com/user-attachments/assets/f5632c3f-fcc6-4842-961e-68f221c038fd)

Se não por esse método, garanta que está parametrizado no 'C:\...\FaturamentoDistribuidora' esteja com o seguinte comando:

  ```
  <ItemGroup>
    <None Update="Faturamento052024.json">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
  </ItemGroup>
  ```

  ![image](https://github.com/user-attachments/assets/1842c3a1-222b-4a5c-93b3-3fb68476813b)


Obs: Altere para o nome do arquivo que desejar ler, depois de adicioná-lo à pasta do projeto. Atente-se que o nome das variáreis no arquivo JSON devem ser **idênticas** às dos atributos das classes do C#. No caso: Faturamento, Data e Valor.

![image](https://github.com/user-attachments/assets/dd64be66-dc0b-49f7-835d-ddc0393cae14)

Após abrir a pasta disponilizada nesse respositório no Visual Studio 2022 ou no Visual Studio Code, abra o arquivo Program.cs na IDE e aperte F5, ou interaja com o play como mostra a imagem abaixo:

![image](https://github.com/user-attachments/assets/1fe8a2c0-6f6a-4252-8de9-905b91eac74f)

No console que irá abrir, digite um valor e confirme com Enter!
