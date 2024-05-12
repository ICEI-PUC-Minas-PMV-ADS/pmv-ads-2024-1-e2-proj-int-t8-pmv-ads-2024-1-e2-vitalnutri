# Programação de Funcionalidades

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir aos usuários a realização de cadastro de acordo com o perfil (Paciente, nutricionista ou educador físico)  | Register.cshtml / Register.cshtml.cs |
|RF-002| A aplicação deve permitir o acesso de usuários por meio do login e senha cadastradas   | Login.cshtml / Login.cshtml.cs |
|RF-021| A aplicação deve permitir ao nutricionista o cadastro de alimentos  | Index.cshtml / Edit.cshtml / Details.cshtml / Delete.cshtml/ Create.cshtml/ AlimentoController.cs |
|RF-022| A aplicação deve permitir ao educador físico o cadastro de exercícios  | Index.cshtml / Edit.cshtml / Details.cshtml / Delete.cshtml/ Create.cshtml/ ExercicioController.cs |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  | Artefato(s) produzido(s) |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser compatível com os principais navegadores de mercado (Google Chrome, Microsoft Edge, Firefox e Opera)   | Sim | 
|RNF-002| A aplicação deve ser responsiva e permitir a visualização em computadores, tablets e dispositivos móveis   |  Sim | 
|RNF-003| A aplicação deve ser publicada em um ambiente acessível público na Internet da microsoft, azure  | Sim | 


# Instruções de acesso
Executar em localhost.

1. Abrir a solução vitalnutri.sln
2. Abrir o arquivo appconfig.json e modificar a string de conexão apontando para a instância do banco local. Ex. SQLEXPRESS
3. No Package Managemt Console executar o comando: Update Database e aguardar o término da excução das migrations
4. Partir a aplicação

Nutricionista:
Usuário: nutricionista@vitalnutri.com
Senha: 123456

Treinador:
Usuário: treinadorvitalnutri.com
Senha: 123456

Cliente:
Usuário: treinadorvitalnutri.com
Senha: 123456

