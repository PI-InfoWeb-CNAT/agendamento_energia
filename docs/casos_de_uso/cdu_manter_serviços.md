# Projeto Agendamento de Serviços

## Especificação do caso de uso - Manter Serviços

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 29/11/2021 | **1.00** | Versão Inicial  | Ruth Silva |

### 1. Resumo 

O funcionário verifica se os serviços estão cadastrados, caso não, efetua o cadastro ou pode modificá-lo se ele estiver somente desatualizado. 

### 2. Atores 

Funcionário

### 3. Pré-condições

O funcionário deverá estar autenticado e caso deseje modificar um serviço, o serviço deve estar cadastrado de acordo com as propriedades que possui. 

### 4. Pós-condições

O serviço continua ou  torna-se  disponível para que o cliente possa ter acesso.

### 5. Fluxos de Evento

#### 5.1. Fluxo Básico

| Ator   | Sistema |
|:-------|:--------|
|| 1.O sistema apresenta ao funcionário uma aba onde é possível que ele acesse aos serviços cadastrados, modifique-os ou inclua caso seja necessário. |
| 2. .O funcionário pode modificar as opções de serviço, valor e detalhes do mesmo ou acrescenta um serviço caso precise. ||
|| 3. Após realizar as tarefas necessárias no serviço, o sistema salvará as mudanças e elas serão visiveis para os usuarios. |

#### 5.2. Fluxo de Exceção

| Exceção | Sistema |
|:--------|:--------|
| 1. Dados inválidos para a operação | Caso os dados informados não possuam a quantidade ou caracteres corretos, é exibida uma mensagem de erro e o cadastro não é concluído. |
| 2. Serviço já cadastrado| Caso o funcionário queira adicionar um serviço que já foi incluído deve ser apresentada uma mensagem  de retorno onde o informa e também dá a opção de modificar o serviço que tentou cadastrar. |


### 6. Protótipos de Interface
`A ser desenvolvido pelo aluno.`
