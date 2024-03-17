# Especificações do Projeto

Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários, conforme abaixo. 

## Personas

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t8-pmv-ads-2024-1-e2-vitalnutri/blob/main/docs/img/camila.jpg" alt="Foto de Camila Souza" style="width: 10%;">
  <figcaption> Figura 1 - Foto Camila Souza</figcaption>
</figure>

- Camila Souza, aos 29 anos, graduada em Comunicação e imersa na dinâmica comercial de uma empresa multinacional, atualmente busca equilíbrio entre crescimento profissional e vida pessoal. Com uma pós-graduação em Gestão Comercial em curso, ela encontra prazer em explorar novos destinos e apreciar a sutileza dos vinhos. Contudo, enfrenta desafios como insônia devido ao volume de trabalho, preocupações com sua saúde física e mental, e dificuldades em manter hábitos alimentares e de exercício saudáveis, revelando uma busca por mudança e bem-estar integral.
<br><br><br>

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t8-pmv-ads-2024-1-e2-vitalnutri/blob/main/docs/img/rosana.jpg" style="width: 23%;"
    <figcaption> Figura 2 - Foto Rosana Alves</figcaption>
</figure>

- Rosana Alves, 38 anos, nutricionista com 14 anos de experiência e especialização em nutrição esportiva. Oferece consultas online e presenciais, buscando ajudar os outros e encontrar satisfação profissional. Seus desafios incluem lidar com a pressão por resultados rápidos e o acompanhamento individualizado dos pacientes. Nas horas vagas, gosta de praticar atividades físicas, ler e fazer passeios ao ar livre.
<br><br><br>

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t8-pmv-ads-2024-1-e2-vitalnutri/blob/main/docs/img/luan.jpg" style="width: 23%;"
    <figcaption> Figura 3 - Foto Luan Pereira</figcaption>
</figure>

- Luan Pereira, 21 anos, estudante de Engenharia Civil no 5º período, estagia em uma construtora. Além dos estudos, dedica-se ao inglês e ao Autocad. Busca formação profissional, segurança, bem-estar e estabilidade financeira. Suas frustrações incluem estar abaixo do peso, indisposição e negligência com a saúde.
<br><br><br>

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t8-pmv-ads-2024-1-e2-vitalnutri/blob/main/docs/img/amara.jpg" style="width: 23%;"
    <figcaption> Figura 3 - Foto Amara Luci</figcaption>
</figure>

- Amara Luci Godin, aos 24 anos, é uma personal trainer recém-formada em Educação Física e atualmente cursando uma pós-graduação em Fisiologia do Exercício. Sua motivação inclui a busca por qualidade de vida, realização profissional e contribuição social. No entanto, enfrenta frustrações com pacientes que não seguem os treinos, dificuldade dos alunos em manter constância e falta de conciliação entre dieta e exercícios. Apesar dos desafios, está determinada a ajudar seus alunos a alcançarem uma vida mais saudável e ativa.
<br><br><br>

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Camila Souza  | Registrar minhas refeições e atividades fisicas           | Acompanhamento profissional no período entre consultas               |
|Camila Souza       | Consultar os macronutrientes das minhas refeições                 | Aprendizado sobre a minha reeducação alimentar |
|Camila Souza       | Receber recompensas e feedback pelos registros diários                 |Me manter motivada para atingir os objetivos estabelecidos |
|Luan Pereira       | Consutar Meu IMC                 | Analisar meu desenvolvimento |
|Luan Pereira       | Salvar minhas refeições e treinos preferidos                 | Facilitar a repetição de registros iguais |
|Amara Luci       | Registrar o plano de treino dos meus alunos                 | que o aluno possa visualizar e realizar as atividades |
|Amara Luci       | Acompanhar os check-in dos meus alunos                 | Verificar se ele está seguindo de maneira ordeira o planejamento |
|Amara Luci       | Tomar ciência sobre a audência de check-in dos meus alunos                 |Alertá-lo e incentiva-lo |
|Rosana Alves       | Registrar o plano alimentar dos meus pacientes                 | Que o aluno possa visualizar e realizar as refeições planejadas  |
|Rosana Alves       | Acompanhar o registro de refeições dos meus pacientes                 | Verificar se ele está seguindo o planejamento |
|Rosana Alves       | Tomar ciência sobre ausência de registro de refeições dos meus pacientes                 | Alertá-lo e incentiva-lo |


## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir. 

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues. 

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir aos usuários a realização de cadastro de acordo com o perfil (Paciente, nutricionista ou educador físico)  | ALTA | 
|RF-002| A aplicação deve permitir o acesso de usuários por meio do login e senha cadastradas    | ALTA |
|RF-003| A aplicação deve permitir ao nutricionista inserir, modificar e excluir um plano alimentar no prontuário do paciente | ALTA |
|RF-004| A aplicação deve possibilitar ao educador físico inserir, modificar e excluir o treinamento individual personalizado no prontuário do paciente.   | ALTA |
|RF-005| A aplicação deve permitir ao usuário consultar os planos cadastrados pelos profissionais no seu prontuário (dieta e treino)   | ALTA |
|RF-006| A aplicação deve possibilitar o registro das refeições e trenos realizadas pelo paciente   | ALTA |
|RF-007| A aplicação deve possibilitar o registro das refeições realizadas pelo paciente   | ALTA |
|RF-008| A aplicação deve permitir ao nutricionista consultar as refeições registradas pelo paciente   | ALTA |
|RF-009| A aplicação deve permitir ao educador físico consultar os check-ins de treinamento do paciente   | ALTA |
|RF-010| A aplicação deve possibilitar que os profissionais comentem os registros de refeição ou treino realizados pelos pacientes   | MÉDIA |
|RF-011| A aplicação deve possibilitar que profissionais reajam aos registros de refeição ou treino realizados pelos pacientes com emojis   | BAIXA |
|RF-012| A aplicação deve conceder pontuações ao paciente a cada tarefa diária cumprida   | MÉDIA |
|RF-013| A aplicação deve disponibilizar o cálculo de macronutrientes das refeições do usuário   | MÉDIA |
|RF-014| A aplicação deve exibir um alerta ou um lembrete quando o usuário não registrar sua refeição ou o seu treino   | MÉDIA |
|RF-015| A aplicação deve permitir que que os pacientes cadastrem as seguintes informações: peso, altura, sexo, idade e meta de peso   | BAIXA |
|RF-016| A aplicação deve permitir que os pacientes salvem suas refeições e treinos preferidos   | BAIXA |
|RF-017| A aplicação deve permitir uma funcionalidade de filtro e pesquisa para as refeições  | BAIXA |
|RF-018| A aplicação deve exibir notificações para os profissionais quando o paciente fizer o registro de refeições e treinos  | BAIXA |
|RF-019| A aplicação deve exibir o cálculo do IMC do paciente  | BAIXA |


### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender. 

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser compatível com os principais navegadores de mercado (Google Chrome, Microsoft Edge, Firefox e Opera)   | Alta | 
|RNF-002| A aplicação deve ser responsiva e permitir a visualização em computadores, tablets e dispositivos móveis   |  Alta | 
|RNF-003| A aplicação deve ser publicada em um ambiente acessível público na Internet   | Alta | 
|RNF-004| A plataforma deve ser desenvolvida utilizando tecnologias em seu estado primitivo, como HTML, CSS e Javascript para fins acadêmicos   |  Alta | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir. 

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 23/06/2024. |
|RE-02| O aplicativo deve se restringir às tecnologias básicas da Web no Frontend.         |
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho.         |

## Diagrama de Casos de Uso

A imagem abaixo representa o Diagrama de Casos de Uso realizado através Ludid App com o objetivo de elucidar as principais funcionalidades da aplicação.

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t8-pmv-ads-2024-1-e2-vitalnutri/blob/main/docs/img/Diagrama%20de%20Caso%20de%20Uso.PNG"
    <figcaption> Figura 5 - Diagrama de Casos de Uso</figcaption>
</figure>

<br>
<br>

Link de acesso: https://lucid.app/lucidchart/03e6e25e-01e1-41c8-8800-5fa6b47b09b5/edit?viewport_loc=59%2C157%2C1981%2C911%2C.Q4MUjXso07N&invitationId=inv_d754d0de-04cd-4802-811b-c6a6f4dcb956
