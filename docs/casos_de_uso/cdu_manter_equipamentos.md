# Projeto Agendamento de Servi�os

## Especifica��o do caso de uso - Manter Servi�os

### Hist�rico da Revis�o 

|  Data  | Vers�o | Descri��o | Autor |
|:-------|:-------|:----------|:------|
| 29/11/2021 | **1.00** | Vers�o Inicial  | Rafael Campelo |

### 1. Resumo 

O funcion�rio seleciona os produtos, entre as tr�s op��es dispon�veis (Inversor, M�dulo e Estrutura), e, em seguida, ir� inserir a pot�ncia do produto, caso tenha selecionado a op��o m�dulo ou inversor. O funcion�rio dever� anexar o Datasheet do produto. Al�m disso, poder� detalhar o produto, caso tenha que explicar alguma condi��o externa.

### 2. Atores 

Funcion�rio

### 3. Pr�-condi��es

O produto escolhido deve obrigatoriamente ser um dos disponibilizado pela empresa.O funcion�rio deve estar logado em sua conta. 

### 4. P�s-condi��es

O produto deve ser disponibilizado ao cliente.

### 5. Fluxos de Evento

#### 5.1. Fluxo B�sico

| Ator   | Sistema |
|:-------|:--------|
|| 1.O sistema apresenta uma tela onde � poss�vel fazer a inser��o, edi��o ou remo��o de novos produtos. |
| 2. O funcion�rio modifica ou acrescenta o produto caso ||
|| 3. Ap�s realizar as tarefas necess�rias no equipamento, o sistema salvar� as mudan�as e elas ser�o visiveis para os usuarios. |

#### 5.2. Fluxo de Exce��o

| Exce��o | Sistema |
|:--------|:--------|
| 1. Dados inv�lidos para a opera��o | Caso os dados informados n�o possuam a quantidade ou caracteres corretos, � exibida uma mensagem de erro e o cadastro n�o � conclu�do. |
| 2. Equipamento j� cadastrado| Caso o funcion�rio queira adicionar um equipamento que j� foi inclu�do deve ser apresentada uma mensagem  de retorno onde o informa e tamb�m d� a op��o de modificar o equipamento que tentou cadastrar. |


### 6. Prot�tipos de Interface
`A ser desenvolvido pelo aluno.`
