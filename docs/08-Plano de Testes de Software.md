# Plano de Testes de Software

Os testes funcionais a serem realizados na aplicação são descritos a seguir.
 
| **Caso de Teste** 	| **CT-01 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	**Requisito Associado** 	| RF-001 - A aplicação deve permitir aos usuários a realização de cadastro de acordo com o perfil (Paciente, nutricionista ou educador físico) <br> RF-015 - A aplicação deve permitir que os pacientes cadastrem as seguintes informações: peso, altura, sexo, idade e meta de peso. <br> RF-019 - A aplicação deve exibir o cálculo do IMC do paciente. |
| **Objetivo do Teste** 	| Verificar se o usuário consegue se cadastrar na aplicação. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Login" <br> - Clicar em Registrar - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF ou Registro do seu conselho, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" <br> - Clicar em "prontuario" <br> - Verificar se todos os dados estão corretos. <br> - Verificar se o sistema está calculando e exibindo corretamente o IMC.|
|**Critério de Êxito** | - O cadastro foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste**  	| **CT-02 – Efetuar login**	|
|**Requisito Associado** | RF-002	- A aplicação deve permitir o acesso de usuários por meio do login e senha cadastradas |
| **Objetivo do Teste** 	| Verificar se o usuário consegue realizar login. |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|**Critério de Êxito** | - O login foi realizado com sucesso. |
|  	|  	|
| **Caso de Teste**  	| **CT-03 – CRUD de plano alimentar**	|
|**Requisito Associado** | RF-003	- A aplicação deve permitir ao nutricionista inserir, modificar e excluir um plano alimentar no prontuário do paciente. |
|**Objetivo do Teste** 	| Verificar se o usuário (nutricionista) consegue inserir, modificar e excluir um plano alimentar |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como nutricionista <br> - Clicar no campo Paciente <br> - Selecionar paciente. <br> - Clicar em "Adicionar P.A" <br> - Clicar em "Adicionar alimento". <br> - Clicar no simbolo "lapis" para editar. <br> - Clicar no simbolo "x" para excluir. |
|**Critério de Êxito** | - A Inserção de alimento, edição e exclusão feitas com sucesso. |
|  	|  	|
| **Caso de Teste**  	| **CT-04 – CRUD de plano de Treino**	|
|**Requisito Associado** | RF-004	- A aplicação deve possibilitar ao educador físico inserir, modificar e excluir o treinamento personalizado no prontuário do paciente. |
| **Objetivo do Teste** 	| Verificar se o usuário (Personal) consegue inserir, modificar e excluir um plano de treinamentos |
| **Passos**	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como Educador físico <br> - Clicar no campo Paciente <br> - Selecionar paciente. <br> - Clicar em "Adicionar Treino" <br> - Clicar em "Adicionar Exercicio". <br> - Clicar no simbolo "lapis" para editar. <br> - Clicar no simbolo "x" para excluir. |
|**Critério de Êxito** | - A Inserção de exercicios, edição e exclusão feitas com sucesso. |
|  	|  	|
| **Caso de Teste**  	| **CT-05 – Visualizar dieta e treino**	|
|**Requisito Associado** | RF-005	- A aplicação deve permitir ao usuário consultar os planos cadastrados pelos profissionais no seu prontuário (dieta e treino) <br> RF-013 - A aplicação deve disponibilizar o cálculo de macronutrientes das refeições do usuário	 |
| **Objetivo do Teste** 	| Verificar se o paciente consegue visualizar seu prontuario com dieta e treino |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como Paciente. <br> - Clicar no campo Dieta. <br> - Visualizar dieta. <br> - Clicar em "Treino Personalizado" <br> - Visualizar Treino.|
|**Critério de Êxito** | - Conseguir visualizar dieta e treino com clareza.|
|  	|  	|
| **Caso de Teste**  	| **CT-06 – Registro de Check-ins**	|
|**Requisito Associado** | RF-006	- A aplicação deve possibilitar o registro dos treinos realizadas pelo paciente. <br> RF-007 - A aplicação deve possibilitar o registro das refeições, juntamente com uma imagem realizada pelo paciente. |
| **Objetivo do Teste** 	| Verificar se o paciente consegue realizar o check-ins do seu treino realizado e check-in de refeição feita e inserir uma imagem.|
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como Paciente <br> - Clicar no campo Dieta <br> - Clicar em "Café da manhã" <br> - Clicar em "registrar refeição" <br> - Clicar "enviar imagem" <br> - Clicar em "confirmar"  <br> - Clicar em "Home" <br> - Clicar no campo treino <br> - Selecionar treino do dia. <br> Clicar em "registrar". |
|**Critério de Êxito** | - Conseguir registrar qualquer refeição cadastrada e qualquer treino.|
|  	|  	|
| **Caso de Teste**  	| **CT-07 – Visualizar, Comentar e reagir aos registro do paciente**	|
|**Requisito Associado** | RF-008	- A aplicação deve permitir ao nutricionista consultar as refeições registradas pelo paciente. <br> RF-010 - A aplicação deve possibilitar que os profissionais comentem os registros de refeição ou treino realizados pelos pacientes. <br> RF-011 - A aplicação deve possibilitar que profissionais reajam aos registros de refeição ou treino realizados pelos pacientes com emojis.|
| **Objetivo do Teste** 	| Verificar se o nutricionista consegue Visualizar os check-ins dos seus paciente e comentar e/ou reagir com um emoji.|
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como Nutricionsta <br> - Clicar no campo paciente <br> - Clicar em "visualizar" <br> - Selecionar um dia aleatoria anterior a data do teste. <br> - Clicar em "visualizar" <br> - Clicar em "comentar"  <br> - Digitar "caribe é o melhor" <br> - Clicar em "confirmar <br> - verificar se o comentario foi postado. <br> Clicar no simbolo "emoji" e escolher a reação. <br> - Verificar se foi postada. |
|**Critério de Êxito** | - Conseguir visualizar, comentar e reajir a um dia aleatrorio do paciente.|
|  	|  	|
| **Caso de Teste**  	| **CT-08 – Visualizar, Comentar e reagir aos registro do paciente**	|
|**Requisito Associado** | RF-009	- A aplicação deve permitir ao educador físico consultar os check-ins de treinamento do paciente. <br> RF-010 - A aplicação deve possibilitar que os profissionais comentem os registros de refeição ou treino realizados pelos pacientes. <br> RF-011 - A aplicação deve possibilitar que profissionais reajam aos registros de refeição ou treino realizados pelos pacientes com emojis.|
| **Objetivo do Teste** 	| Verificar se o educardo físico consegue Visualizar os check-ins dos seus paciente e comentar e/ou reagir com um emoji.|
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como educador físico <br> - Clicar no campo paciente <br> - Clicar em "visualizar" <br> - Selecionar um dia aleatoria anterior a data do teste. <br> - Clicar em "visualizar" <br> - Clicar em "comentar"  <br> - Digitar "caribe é o melhor" <br> - Clicar em "confirmar <br> - verificar se o comentario foi postado. <br> Clicar no simbolo "emoji" e escolher a reação. <br> - Verificar se foi postada. |
|**Critério de Êxito** | - Conseguir visualizar, comentar e reajir a um dia aleatrorio do paciente.|
|  	|  	|
| **Caso de Teste**  	| **CT-09 – Verificar Pontuação**	|
|**Requisito Associado** | RF-012	- A aplicação deve conceder pontuações ao paciente a cada tarefa diária cumprida. |
| **Objetivo do Teste** 	| Verificar se o paciente recebe as pontuações ao fazer os check-ins|
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como Paciente <br> - Clicar no campo Dieta <br> - Clicar em "Café da manhã" <br> - Clicar em "registrar refeição" <br> - Clicar "enviar imagem" <br> - Clicar em "confirmar"  <br> - Clicar em "Home" <br> -Verificar se houve alteração na pontuação. <br>  - Clicar no campo treino <br> - Selecionar treino do dia. <br> Clicar em "registrar". <br> - Clicar em "Home" <br> - Verificar se houve alteração na pontuação.|
|**Critério de Êxito** | - Alterações na pontuação de acordo com registro feito.|
|  	|  	|
| **Caso de Teste**  	| **CT-10 – Verificar notificações**	|
|**Requisito Associado** | RF-014	- A aplicação deve exibir um alerta ou um lembrete ao paciente sobre suas refeições e treinamento. <br> RF-020	- A aplicação deve enviar notificações ao paciente a respeito de sua evolução. |
| **Objetivo do Teste** 	| Verificar se o paciente recebe as notificações do sistema.|
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como Paciente <br> - Verificar se na home está dispostas as notificações.|
|**Critério de Êxito** | - Notificações exibidas.|
|  	|  	|
| **Caso de Teste**  	| **CT-11 – Verificar Filtro e comandor para salvar**	|
|**Requisito Associado** | RF-016	- A aplicação deve permitir que os pacientes salvem suas refeições e treinos preferidos. <br> RF-017 - A aplicação deve permitir uma funcionalidade de filtro e pesquisa para as refeições.	 |
| **Objetivo do Teste** 	| Verificar se o paciente consegue visualizar seu prontuario com dieta e treino |
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como Paciente. <br> - Clicar no campo Dieta. <br> - Visualizar dieta. <br> - Clicar no simbolo "lupa" <br> - Buscar refeição "caribe" <br> - Clicar na refeição. <br> - Clicar em "salvar". <br> - Verificar se foi salva. <br> - Clicar em "Treino Personalizado" <br> - Visualizar Treino. <br> - Clicar no simbolo "lupa" <br> - Buscar exercicio "supino" <br> - Clicar no exercicio. <br> - Clicar em "salvar". <br> - Verificar se foi salva. <br>|
|**Critério de Êxito** | - Conseguir filtrar a refeição e treino desejado e salva-los.|
|  	|  	|
| **Caso de Teste**  	| **CT-12 – Verificar notificações profissionais**	|
|**Requisito Associado** | RF-018	- A aplicação deve exibir notificações para os profissionais quando o paciente não fizer o registro de refeições e treinos por mais de 14 dias. |
| **Objetivo do Teste** 	| Verificar se o paciente recebe as notificações do sistema.|
| **Passos** 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "login" <br> - Realizar login como Educador físico <br> - Verificar se na home está dispostas as notificações. <br> Clicar em "sair" <br> - Clicar em "login" <br> - Realizar login como Nutricionista. <br> - Verificar se na home está dispostas as notificações.|
|**Critério de Êxito** | - Notificações exibidas.|

 

