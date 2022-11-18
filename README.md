# 📧VoglioDire📧
Desenvolvi essa API para enviar emails diários para minha namorada com frases/pensamentos/piadas que lembro durante o dia a dia. A ideia principal, 
é configurar o agendador de tarefas do seu servidor para requisitar o endpoint
de envio de email diáriamente. A API foi desenvolvida pensando em adicionar diferentes tipos de emails, e personalizá-los através de HTML/CSS.

## 💻 Tecnologias Utilizadas
- [X] ASP.NET CORE 3.1
- [X] MailKit
- [X] Newtonsoft.json
- [X] Swagger
## 📚 Patterns Utilizados
- [X] Facade
- [X] Factory

## Como configurar ?
Preencha o appsettings.json com as informações do protocolo SMTP do seu host. Os atributos "StartDate" e "EndDate" servem para encontrar o índice no dicionário que contém
a mensagem do dia, o dicionário fica no arquivo "Messages.json" contido na pasta src/Messages/ (Crie seu arquivo, com suas mensagens). A ideia do arquivo "Messages.json" é de não ser necessário realizar novamente o deploy da aplicação para
inserir novas mensagens, e sim, utilizar o gerenciador de arquivos do seu servidor. 
