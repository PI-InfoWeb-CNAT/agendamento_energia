# Projeto Agendamento de Servi�os

##  Documentação caso de uso Confirmar Agendamento

### Hist�rico da Revis�o 

|  Data  | Vers�o | Descri��o | Autor |
|:-------|:-------|:----------|:------|
| 27/12/2021 | **1.00** | Vers�o Inicial  | Rafael Campelo |

### 1. Resumo 

Nesse caso de uso, o sistema permite ao funcionário a opção de confirmar ou cancelar o agendamento.

### 2. Atores 

Funcionário

### 3. Pr�-condi��es

O funcionário  deve ter efetuado o login na página inicial e ter selecionado uma data válida na tela de abrir agendamentos do dia.

### 4. P�s-condi��es

O cliente recebe a confirmação.

### 5. Fluxos de Evento

#### 5.1. Fluxo B�sico

| Ator   | Sistema |
|:-------|:--------|
|| 1. O sistema apresenta uma tela onde é possível confirmar/cancelar o agendamento |
| 2. O funcionário realiza a confirmação/cancelamento do agendamento. ||
|| 3..O sistema apresenta ao funcionário uma mensagem de que o agendamento foi confirmado/cancelado com sucesso sistema fotovoltaico. |

#### 5.2. Fluxo de Exce��o

| Exce��o | Sistema |
|:--------|:--------|
| 1. Dados inv�lidos para a opera��o | Caso sejam inseridas datas inválidas, o sistema exibirá um alerta.
