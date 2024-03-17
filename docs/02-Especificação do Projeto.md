# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

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
|RF-001| A aplicação deve permitir que o usuário gerencie suas tarefas | ALTA | 
|RF-002| A aplicação deve emitir um relatório de tarefas realizadas no mês   | MÉDIA |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender. 

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser compatível com os principais navegadores de mercado (Google Chrome, Microsoft Edge, Firefox e Opera);  | Alta | 
|RNF-002| A aplicação deve ser responsiva e permitir a visualização em computadores, tablets e dispositivos móveis.  |  Alta | 
|RNF-003| A aplicação deve ser publicada em um ambiente acessível público na Internet.   |  Média | 
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

A iamagem abaixo representa o Diagrama de Casos de Uso realizado através Ludid App com o objetivo de elucidar as principais funcionalidades da aplicação.

<figure> 
  <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t8-pmv-ads-2024-1-e2-vitalnutri/blob/main/docs/img/Diagrama%20de%20Caso%20de%20Uso.PNG"
    <figcaption> Figura 1 - Diagrama de Casos de Uso</figcaption>
</figure>

<br>
<br>

Link de acesso: https://lucid.app/lucidchart/03e6e25e-01e1-41c8-8800-5fa6b47b09b5/edit?viewport_loc=59%2C157%2C1981%2C911%2C.Q4MUjXso07N&invitationId=inv_d754d0de-04cd-4802-811b-c6a6f4dcb956
