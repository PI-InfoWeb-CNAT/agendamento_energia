# Projeto Agendamento de Serviços

## Especificação do caso de uso - Dashboard de Agenda

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 16/07/2021 | **1.00** | Versão Inicial  | Gilbert Azevedo |

### 1. Resumo 

Nesse caso de uso, o usuário funcionário acessa o sistema e visualiza o painel de controle (dashboard) da agenda do profissional ou da empresa, que disponibiliza o acesso às demais operações do sistema relacionadas à agenda.

### 2. Atores 

Funcionário

### 3. Pré-condições

O funcionário deve estar autenticado no sistema.

### 4. Pós-condições

O sistema apresenta a agenda do profissional ou da empresa para a data e o serviço informados pelo funcionário.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
|| 1. O sistema apresenta o painel de controle da agenda com controles que permitem ao funcionário selecionar uma data e um serviço. O controle de seleção de data deve iniciar no dia atual. O controle de seleção de serviço deve iniciar vazio, se houver mais de um tipo de serviço disponível, ou com o serviço selecionado, caso apenas um serviço esteja disponível. |
| 2. O funcionário ajusta, se necessário, os controles de seleção de data e serviço e submete a consulta ao sistema. ||
|| 3. O sistema apresenta no formato de tabela os horários da agenda do dia e serviço informados, disponibilizando as opções de confirmar um agendamento e excluir um agendamento, para cada horário da agenda, e de abrir a agenda do dia, para gerenciar o cadastro de horários disponíveis. O sistema deve apresentar todos os horários da agenda do dia, informando os dados dos clientes. |

#### 5.2. Fluxo de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Se o usuário não selecionar uma data e um serviço para a realização da consulta, o sistema deve apresentar um alerta de dados não informados e a consulta não é realizada. Essa operação se repete até que uma data e um serviço sejam informados. |


### 6. Protótipos de Interface
`A ser desenvolvido pelo aluno.`
