# Projeto Agendamento de Serviços

## Especificação do caso de uso - Manter Serviços

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 29/11/2021 | **1.00** | Versão Inicial  | Rafael Campelo |

### 1. Resumo 

O funcionário seleciona os produtos, entre as três opções disponíveis (Inversor, Módulo e Estrutura), e, em seguida, irá inserir a potência do produto, caso tenha selecionado a opção módulo ou inversor. O funcionário deverá anexar o Datasheet do produto. Além disso, poderá detalhar o produto, caso tenha que explicar alguma condição externa.

### 2. Atores 

Funcionário

### 3. Pré-condições

O produto escolhido deve obrigatoriamente ser um dos disponibilizado pela empresa.O funcionário deve estar logado em sua conta. 

### 4. Pós-condições

O produto deve ser disponibilizado ao cliente.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
|| 1.O sistema apresenta uma tela onde é possível fazer a inserção, edição ou remoção de novos produtos. |
| 2. O funcionário modifica ou acrescenta o produto caso ||
|| 3. Após realizar as tarefas necessárias no equipamento, o sistema salvará as mudanças e elas serão visiveis para os usuarios. |

#### 5.2. Fluxo de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Caso os dados informados não possuam a quantidade ou caracteres corretos, é exibida uma mensagem de erro e o cadastro não é concluído. |
| 2. Equipamento já cadastrado| Caso o funcionário queira adicionar um equipamento que já foi incluído deve ser apresentada uma mensagem  de retorno onde o informa e também dá a opção de modificar o equipamento que tentou cadastrar. |


### 6. Protótipos de Interface
`A ser desenvolvido pelo aluno.`
