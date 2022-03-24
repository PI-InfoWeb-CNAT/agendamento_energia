# Projeto Agendamento de Servi�os

## Especifica��o do caso de uso - Manter Servi�os

### Hist�rico da Revis�o 

|  Data  | Vers�o | Descri��o | Autor |
|:-------|:-------|:----------|:------|
| 29/11/2021 | **1.00** | Vers�o Inicial  | Ruth Silva |

### 1. Resumo 

O funcion�rio verifica se os servi�os est�o cadastrados, caso n�o, efetua o cadastro ou pode modific�-lo se ele estiver somente desatualizado. 

### 2. Atores 

Funcion�rio

### 3. Pr�-condi��es

O funcion�rio dever� estar autenticado e caso deseje modificar um servi�o, o servi�o deve estar cadastrado de acordo com as propriedades que possui. 

### 4. P�s-condi��es

O servi�o continua ou  torna-se  dispon�vel para que o cliente possa ter acesso.

### 5. Fluxos de Evento

#### 5.1. Fluxo B�sico

| Ator   | Sistema |
|:-------|:--------|
|| 1.O sistema apresenta ao funcion�rio uma aba onde � poss�vel que ele acesse aos servi�os cadastrados, modifique-os ou inclua caso seja necess�rio. |
| 2. .O funcion�rio pode modificar as op��es de servi�o, valor e detalhes do mesmo ou acrescenta um servi�o caso precise. ||
|| 3. Ap�s realizar as tarefas necess�rias no servi�o, o sistema salvar� as mudan�as e elas ser�o visiveis para os usuarios. |

#### 5.2. Fluxo de Exce��o

| Exce��o | Sistema |
|:--------|:--------|
| 1. Dados inv�lidos para a opera��o | Caso os dados informados n�o possuam a quantidade ou caracteres corretos, � exibida uma mensagem de erro e o cadastro n�o � conclu�do. |
| 2. Servi�o j� cadastrado| Caso o funcion�rio queira adicionar um servi�o que j� foi inclu�do deve ser apresentada uma mensagem  de retorno onde o informa e tamb�m d� a op��o de modificar o servi�o que tentou cadastrar. |


### 6. Prot�tipos de Interface
`A ser desenvolvido pelo aluno.`
