# Projeto Agendamento de Serviços

## Especificação do caso de uso - Consultar Agenda do Dia

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/07/2021 | **1.00** | Versão Inicial  | Gilbert Azevedo |

### 1. Resumo 

Nesse caso de uso, o usuário cliente acessa o sistema e consulta a agenda do profissional ou da empresa para verificar os horários de atendimentos que estão disponíveis para agendar um serviço.

### 2. Atores 

Cliente

### 3. Pré-condições

O cliente deve estar autenticado no sistema.

### 4. Pós-condições

O sistema apresenta a agenda do profissional ou da empresa para a data e o serviço informados pelo cliente.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
|| 1. O sistema apresenta a página de consulta da agenda com controles que permitem ao usuário selecionar uma data e um serviço. O controle de seleção de data deve iniciar no dia atual. O controle de seleção de serviço deve iniciar vazio, se houver mais de um tipo de serviço disponível, ou com o serviço selecionado, caso apenas um serviço esteja disponível. |
| 2. O usuário ajusta, se necessário, os controles de seleção de data e serviço e submete a consulta ao sistema. ||
|| 3. O sistema apresenta no formato de tabela os horários da agenda do dia e serviço informados, disponibilizando uma opção de agendar um serviço (do tipo informado) em horários que ainda estejam disponíveis. O sistema pode apresentar todos os horários da agenda do dia, mas sem apresentar dados de outros clientes. |

#### 5.2. Fluxo de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Se o usuário não selecionar uma data e um serviço para a realização da consulta, o sistema deve apresentar um alerta de dados não informados e a consulta não é realizada. Essa operação se repete até que uma data e um serviço sejam informados. |


### 6. Protótipos de Interface
`A ser desenvolvido pelo aluno.`
