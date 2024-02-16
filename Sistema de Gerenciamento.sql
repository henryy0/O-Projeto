Create Database SistemaDeGerenciamento
Drop Database SistemaDeGerenciamento
 
use SistemaDeGerenciamento --verdadeiro
 
CREATE TABLE usuario ---tabela Usuário
(
	id_usuario int not null identity primary key , ---Identidade,chave principal,nâo se repete
    nome_usuario VARCHAR(50) NOT NULL,
    login_usuario VARCHAR(30) NOT NULL UNIQUE,
    senha_usuario VARCHAR(30) NOT NULL
);
 
select * from usuario
 
CREATE TABLE Projeto ---tabela Projeto
(
    ID_Projeto INT IDENTITY(1,1) PRIMARY KEY NOT NULL, ---Identidade,chave principal,nâo se repete
    Nome_Projeto VARCHAR(50) UNIQUE NOT NULL,
    Tipo_Projeto VARCHAR(400) NOT NULL,
    Data_inicio_Projeto SMALLDATETIME DEFAULT GETDATE() NOT NULL,
    Data_Fim_Projeto SMALLDATETIME DEFAULT GETDATE() NOT NULL,
    Status_Projeto VARCHAR(20) NOT NULL,
    Resumo_Projeto VARCHAR(200) NOT NULL,
    Riscos_Projeto VARCHAR(200) NOT NULL,
    Orçamento_Projeto INT NOT NULL,
    Recursos_Projeto VARCHAR(200) NOT NULL
);
select*from Projeto

CREATE TABLE Tarefa ---tabela Tarefa
(
    ID_tarefa INT IDENTITY PRIMARY KEY NOT NULL,
    Projeto_tarefa INT NOT NULL,
    Nome_tarefa VARCHAR(50) UNIQUE NOT NULL,
    Data_inicio_Projeto SMALLDATETIME DEFAULT GETDATE() NOT NULL,
    Data_Fim_Projeto SMALLDATETIME DEFAULT GETDATE() NULL,
    Obs_tarefa VARCHAR(400) NOT NULL,
    Status_tarefa VARCHAR(20) NOT NULL,
 
    CONSTRAINT FK_Projeto_tarefa FOREIGN KEY (Projeto_tarefa) REFERENCES Projeto(ID_Projeto) ---Dados da Tabela Tarefa se referindo a outra Tabela Projeto
);
 
select*from Tarefa
 
CREATE TABLE Chat ---tabela Chat 
(
    ID_chat INT IDENTITY(1,1) PRIMARY KEY, -----Identidade do Chat ,Ex:Ana conversa com João,João conversa com Maria,Ana conversa com ela mesma
    mensagem_chat NVARCHAR(MAX),
    id_usuario1_chat INT,     ---É necessário dois usuários para conversar 
    id_usuario2_chat INT,     ---É necessário dois usuários para conversar 
    data_envio Smalldatetime DEFAULT GETDATE(),
 
    CONSTRAINT FK_id_usuario1_chat FOREIGN KEY (id_usuario1_chat) REFERENCES usuario(id_usuario), ---Dados da Tabela Chat se referindo a outra Tabela Usuário
    CONSTRAINT FK_id_usuario2_chat FOREIGN KEY (id_usuario2_chat) REFERENCES usuario(id_usuario)  ---Dados da Tabela Chat se referindo a outra Tabela Usuário
);
 
 
CREATE TABLE mensagem ---tabela Mensagem
(
    id_chat_mensagem INT NOT NULL, ---Identidade das Mensagem de um Chat 
    id_usuario_mensagem INT NOT NULL,----Identidade das Mensagems de um Usuário
    texto_mensagem NVARCHAR(MAX) NOT NULL,
    data_mensagem DATETIME NOT NULL DEFAULT GETDATE(),
    status_mensagem BIT NOT NULL DEFAULT 0,
    CONSTRAINT PK_mensagem PRIMARY KEY (id_chat_mensagem, id_usuario_mensagem, data_mensagem),
 
    CONSTRAINT FK_id_chat_mensagem FOREIGN KEY (id_chat_mensagem) REFERENCES Chat(ID_chat),  ---Dados da Tabela Mensagem se referindo a outra Tabela Chat
    CONSTRAINT FK_id_usuario_mensagem FOREIGN KEY (id_usuario_mensagem) REFERENCES usuario(id_usuario) ---Dados da Tabela Mensagem se referindo a outra Tabela Chat
);
 
 
CREATE TABLE Equipe ---tabela Equipe
(
    equipe_id INT PRIMARY KEY IDENTITY(1,1),
    equipe_nome NVARCHAR(100) NOT NULL UNIQUE,
    equipe_descricao VARCHAR(MAX),
    equipe_lider_id INT,
    Projeto_atribuido_ID INT, -- Adiciona o campo para armazenar o ID do projeto atribuído
 
    CONSTRAINT FK_Equipe_Lider FOREIGN KEY (equipe_lider_id) REFERENCES Usuario(id_usuario), ---Dados da Tabela Equipe se referindo a outra Tabela Usuário
    CONSTRAINT FK_Projeto_atribuido FOREIGN KEY (Projeto_atribuido_ID) REFERENCES Projeto(ID_Projeto) ---Dados da Tabela Equipe se referindo a outra Tabela Projeto 
);
 
select * from Equipe 

CREATE TABLE Calendario ---tabela Calendário
(
    ID INT IDENTITY(1,1) PRIMARY KEY, ---Id do Evento
    Date DATE,        ---Data do Calendário              
    Event NVARCHAR(255)   ---Eventos do Calendário,Ex:Data de Aniversário,Feriado      
);
 
select * from Calendario