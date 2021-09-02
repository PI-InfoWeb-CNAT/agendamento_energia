# Documento de Visão

## Sistema de Agendamento de Serviços da Empresa Energia Solar

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/06/2021 |  **`1.00`** | Versão Inicial  | Gilbert Azevedo |
| 02/09/2021 |  **`1.10`** | Versão Primeira Adaptação  | Gilbert Azevedo |


### 1. Objetivo do Projeto 

O projeto __Agendamento de Serviços__ tem como objetivo prover uma solução simples, acessível e padronizada para o agendamento de serviços através da Internet.

### 2. Descrição do Problema 

|         __        | __   |
|:------------------|:-----|
| **_O problema_**    | Organizar de forma eficiente um agendamento para manutenção / visita tecnica de energia solar. |
| **_afetando_**      | Profissionais e empresas que fornecem diversos serviços à sociedade e pessoas que precisam contratar esses serviços, agendando um horário de atendimento sem muita complicação e com os dados facilmente acessiveis tanto pela empresa quanto pelo cliente. |
| **_cujo impacto é_**| Dificuldade no agendamento do atendimento, dificuldade na contratação dos serviços, perda de clientes (empresas e profissionais) e não realização de serviços (clientes), problemas com esquecimento (empresas e clientes). |
| **_uma boa solução seria_** | Um sistema na Internet que permita aos profissionais e empresas informar a disponibilidade de horários de atendimento, facilitando o agendamento desses atendimentos para seus clientes. E para os clientes, um sistema que facilite a busca de profissionais e empresas para agendamento de um atendimento, além de centralizar essa demanda em um canto de confiança. |

### 3. Descrição dos Usuários

| Nome | Descrição | Responsabilidades |
|:---  |:--- |:--- |
| Administrador  | Realiza as atividades básicas para o início da operação do sistema | Mantém o cadastro dos funcionários responsáveis pela operação da agenda de serviços |
| Funcionário  | Realiza as atividades relacionadas ao controle da agenda de serviços | Mantém o cadastro de serviços; consulta a situação das agendas de serviços; mantém atualizada a agenda de atendimento; confirma o agendamento de clientes e exclui o agendamento de clientes |
| Cliente | Realiza as atividades relacionadas ao agendamento do serviço | Realiza o próprio cadastro no sistema; consulta a agenda de serviços e disponibilidades de atendimento; agenda um serviço; consulta seus agendamentos e cancela um agendamento; Descreve brevemente os "sintomas" percebidos por ele |

### 4. Descrição do Ambiente dos Usuários

Em várias atividades do cotidiano humano é necessário agendar um horário determinado para que uma ação específica seja realizada. Isso ocorre, por exemplo, quando um automóvel vai ser revisado em uma oficina, quando um médico vai consultar um paciente ou quando consertos diversos (hidráulicos, elétricos, dentre outros) são realizados em uma residência. 

No caso da Energia solar, não é incomum que clientes tenham problemas com a concessionaria de energia e não tenham os beneficios que deveriam ter, fazendo-se necessario um contato entre cliente e empresa de forma desestruturada, não só isso como outros prestadores de serviço na casa do cliente acabem acidentalmente mexendo com a estrutura da sua instalação fazendo-se necessaria um reajuste.

Desta forma, a ideia central do sistema é permitir que empresas e profissionais registrem suas disponibilidades de atendimento e que clientes, em geral, possam consultar e agendar horários para realização e contratação de serviços. Com isso, o sistema pode estabelecer um canal de comunicação mais ágil e confiavél entre clientes e empresas ou profissionais.

### 5. Principais Necessidades dos Usuários

Para empresas e profissionais, a necessidade é divulgar sua disponibilidade de atendimentos para viabilizar, de forma mais eficiente, o atendimento dos seus clientes.

Para os clientes, as necessidades são encontrar profissionais e empresas prestadoras de serviço e agendar atendimentos com estes de acordo as disponibilidades de tempo dos envolvidos.

### 6.	Alternativas Concorrentes

As alternativas concorrentes são, em geral, específicas para uma empresa ou profissional. A ideia do sistema proposto é prover uma solução simples, acessível e padronizada para o agendamento de serviços e que pode ser utilizada por quaisquer profissionais e empresas.

### 7.	Visão Geral do Produto

Em resumo, o sistema de Agendamento de Energia Solar é uma aplicação que permite empresas e profissionais registrarem suas disponibilidades de atendimento aos seus clientes, de forma que estes possam consultar e agendar horários para realização de serviços.

O sistema deve ter uma interface amigável e permitir o acesso concorrente de clientes para agendamento de um horário de atendimento.

### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Entrar no sistema | Usuários devem logar no sistema para acessar as funcionalidades relacionadas ao agendamento |
| RF02 | Cadastro de Funcionários | Administrador do sistema mantém o cadastro dos funcionários responsáveis pelo gerenciamento das agendas |
| RF03 | Gerenciamento de Serviços |  Funcionário mantém a relação de serviços prestados pela empresa ou profissional |
| RF04 | Gerenciamento da Agenda | Funcionário registra os horários disponíveis de atendimento, confirma e cancela o agendamento de clientes |
| RF05 | Cadastro de Clientes | Cliente deve realizar o auto cadastramento |
| RF06 | Consulta de Agendas | Cliente consulta agendas de atendimento dos serviços disponíveis, podendo agendar um serviço e descrever brevemente o motivo do agendamento |
| RF07 | Consulta de Agendamento | Cliente consulta atendimentos agendados, podendo cancelar um agendamento |


### 9. Requisitos Não-funcionais

 Código | Nome | Descrição | Categoria | Classificação
|:---  |:--- |:--- |:--- |:--- |
| RNF01 | Design responsivo | O sistema deve adaptar-se a qualquer tamanho de tela de dispositivo, seja, computador, tablets ou smart phones. | Usabilidade| Obrigatório |
| RNF02 | Criptografia de dados| Senhas de usuários devem ser gravadas de forma criptografada no banco de dados. | Segurança | Obrigatório |
| RNF03 | Controle de acesso | Só usuários autenticados podem ter acesso ao sistema, com exceção ao auto cadastramento do usuário. | Segurança | Obrigatório |
| RNF04 | Tempo de resposta |A comunicação entre o servidor e o cliente deve ocorrer em tempo hábil | Performance | Desejável |
| RNF05 | Sistema Web | A aplicação deve ser um site. | Arquitetura | Obrigatório |
| RNF06 | Dados pessoais | Os clientes não devem visualizar dados de outros clientes (na agenda, por exemplo). | Privacidade | Obrigatório |