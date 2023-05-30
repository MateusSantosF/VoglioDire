<h1 align="center">
  📧VoglioDire📧
</h1>

<p align="center">
  <a href="#-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-projeto">Projeto</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-patterns">Patterns Utilizados</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#configuração">Como configurar</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-licença">Licença</a>
</p>

<p align="center">
  <img alt="License" src="https://img.shields.io/static/v1?label=license&message=MIT&color=49AA26&labelColor=000000">
</p>
<br>


## 🚀 Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- ASP.NET CORE 3.1
- MailKit
- Newtonsoft.json
- Swagger

## 📚 Patterns

- Facade
- Factory

## 💻 Projeto

Desenvolvi essa API para enviar emails diários para minha namorada com frases/pensamentos/piadas que lembro durante o dia a dia. A ideia principal, 
é configurar o agendador de tarefas do seu servidor para requisitar o endpoint
de envio de email diáriamente. A API foi desenvolvida pensando em adicionar diferentes tipos de emails, e personalizá-los através de HTML/CSS.

## Configuração
Preencha o appsettings.json com as informações do protocolo SMTP do seu host. Os atributos "StartDate" e "EndDate" servem para encontrar o índice no dicionário que contém
a mensagem do dia, o dicionário fica no arquivo "Messages.json" contido na pasta src/Messages/ (Crie seu arquivo, com suas mensagens). A ideia do arquivo "Messages.json" é de não ser necessário realizar novamente o deploy da aplicação para
inserir novas mensagens, e sim, utilizar o gerenciador de arquivos do seu servidor. 

## :memo: Licença

Esse projeto está sob a licença MIT. Veja o arquivo [LICENSE](/LICENSE) para mais detalhes.

---

<h5 align="center">
 Feito com ♥ by Mateus
</h5>


