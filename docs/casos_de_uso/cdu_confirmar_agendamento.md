# Projeto Agendamento de Serviços

##  Documentação caso de uso Confirmar Agendamento

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 27/12/2021 | **1.00** | Versão Inicial  | Rafael Campelo |
| 27/12/2021 | **1.10** | Formalismo  | Rafael Campelo |

### 1. Resumo 

Nesse caso de uso, o sistema permite ao funcionário a opção de confirmar ou cancelar o agendamento.

### 2. Atores 

Funcionário

### 3. Pré-condições

O funcionário  deve ter efetuado o login na página inicial e ter selecionado uma data válida na tela de abrir agendamentos do dia.

### 4. Pós-condições

O cliente recebe a confirmação.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
| 1. O funcionário abre a tela em questão. ||
|| 2. O sistema apresenta uma tela onde é possível confirmar/cancelar o agendamento |
| 3. O funcionário realiza a confirmação/cancelamento do agendamento. ||
|| 4. O sistema apresenta ao funcionário uma mensagem de que o agendamento foi confirmado/cancelado com sucesso sistema fotovoltaico. |

#### 5.2. Fluxo de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Caso sejam inseridas datas inválidas, o sistema exibirá um alerta.
