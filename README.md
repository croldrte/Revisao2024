# Revisao2024

Projeto desenvolvido durante as aulas do curso técnico em Informática para Internet do [SENAI-MG](https://www.fiemg.com.br/senai/), com o objetivo de trazer à memória conteúdos apresentados antes das férias em 2024.

## GeradorSenhas

Este programa é um gerador de senhas, desenvolvido em C#, que permite ao usuário criar senhas com base em suas preferências. O programa solicita ao usuário a quantidade de caracteres para a senha e se ele deseja incluir letras, números ou caracteres especiais. As senhas geradas são salvas em um arquivo de backup para consulta futura, e o usuário pode visualizá-las sempre que necessário.

### Ferramentas utilizadas

-  **Linguagem de programação:** C#
-  **Framework:** .NET
-  **IDE**: Visual Studio Code
-  **Versionamento:** GIT
-  **Gestão de repositórios:** GitHub

### Funcionalidades básicas

- [x] **Gerar senha**

1. **Entrada de dados do usuário**:
    - O programa solicita ao usuário a quantidade de caracteres que ele deseja para a senha.
    - O usuário escolhe se deseja incluir:
        - Letras maiúsculas e minúsculas.
        - Caracteres especiais como `!`, `@`, `#`, entre outros.
   
2. **Processamento da senha**:
    - O programa calcula a quantidade de números, letras (maiúsculas e minúsculas) e caracteres especiais que irão compor a senha com base nas escolhas do usuário.
    - As percentagens são definidas conforme a escolha:
        - Se o usuário quer letras e caracteres especiais, a senha terá 50% de números, 15% de letras (divididas igualmente entre maiúsculas e minúsculas) e 20% de caracteres especiais.
        - Se o usuário escolher apenas números e letras (sem especiais), os números representam 60% da senha, e as letras 20%.
        - Se o usuário escolher apenas números e caracteres especiais, então a senha terá 70% de números e 30% de caracteres especiais.
        - Se o usuário escolher apenas números, a senha será composta 100% por números.
   
3. **Geração da senha**:
    - O programa utiliza arrays de caracteres para números (`0-9`), letras maiúsculas e minúsculas, e caracteres especiais.
    - Ele seleciona aleatoriamente os caracteres dessas categorias e os distribui de acordo com as quantidades previamente calculadas.
   
4. **Embaralhamento**:
    - Após a senha ser gerada, ela é embaralhada para garantir que a distribuição dos caracteres não siga um padrão previsível (por exemplo, letras sempre no começo, números no meio, etc.).
   
5. **Exibição e armazenamento**:
    - A senha gerada é exibida no console para o usuário.
    - Além disso, a senha gerada é salva no arquivo `bkp.txt` para que o usuário possa consultar posteriormente.

- [x] **Visualizar senhas**

1. **Leitura do arquivo de backup**:
    - Quando o usuário escolhe a opção de visualizar as senhas salvas, o programa verifica se o arquivo `bkp.txt` existe.
   
2. **Exibição das senhas**:
    - Se o arquivo `bkp.txt` existir, o programa lê o conteúdo do arquivo e exibe as senhas salvas para o usuário.
   
3. **Mensagem de erro**:
    - Caso o arquivo não exista (ou esteja vazio), o programa exibe uma mensagem de erro informando que não há senhas salvas no momento.

### Backlog

- [ ] Implementar funções adicionais para verificar a força da senha, como garantir que a senha contenha pelo menos uma letra maiúscula, um número e um caractere especial.
- [ ] Permitir que o usuário possa excluir senhas específicas do arquivo de backup.
- [ ] Incluir uma opção para gerar senhas completamente aleatórias sem qualquer restrição do usuário.

## PadariaDelicioPao

A Padaria DelícioPão é uma marca sólida que combina a experiência de mais de 20 anos com a inovação dos produtos. O ambiente é acolhedor e a qualidade de seus produtos, como pães artesanais e bolos frescos, é um dos maiores diferenciais da padaria. A ideia é transmitir a sensação de "como antigamente, mas com a modernidade de hoje", com foco em cuidado no preparo.

### Público-alvo

- **Famílias**: Pessoas que compram pães, bolos e outros produtos diariamente ou para ocasiões especiais.
- **Trabalhadores e profissionais**: Indivíduos que buscam um lanche rápido ou uma refeição durante o dia de trabalho, como pães de forma, salgados ou cafés.
- **Jovens e estudantes**: Pessoas que procuram opções acessíveis e práticas para lanches rápidos, muitas vezes buscando produtos como pães frescos, sanduíches ou bebidas.

### Objetivos do web site

- Fortalecer a presença digital e reforçar a marca DelícioPão como referência em qualidade e tradição na região.
- Aumentar as vendas online, como encomendas de pães, bolos, salgados e outros produtos.
- Facilitar o contato com o público, oferecendo informações sobre os produtos, promoções e novidades.

### "Imagem" a ser transmitida

- Tradição
- Confiança
- Qualidade
- Frescor

### Conteúdo dinâmico? Qual?

- **Cardápio**: listagem dos produtos atualizada frequentemente com novas opções e promoções sazonais.
- **Galeria de fotos**: atualizações de fotos de produtos novos ou temáticos (festas, datas comemorativas, etc.).
- **Formulário** de pedidos online para facilitar a encomenda de produtos.

### Concorrentes

- **Premialy**
    - Vantagens
        - Grande variedade de produtos
        - Infraestrutura moderna e capacidade produtiva
        - Atendimento a eventos e empresas
        - Promove ações de sustentabilidade

    - Desvantagens
        - Não oferece serviço de delivery
        - Pouco foco em saúde, bem-estar e acessibilidade (ex.: opções sem glúten)

- **Pão Total**
    - Vantagens
        - Tradição e história (Mais de 40 anos no mercado)
        - Grande variedade de produtos
        - Presença em várias cidades
        - Oferece serviço de delivery

    - Desvantagens
        - Falta de sustentabilidade
        - Pouco foco em saúde, bem-estar e acessibilidade (ex.: opções sem glúten)

### Referências

- https://www.padariavianney.com.br
- https://www.padariapampulha.com.br
- https://padariabrasileira.com.br
- https://www.padariajardimbrasil.com.br
- https://www.sabordopao.com.br/
- https://carlosbakery.com.br
