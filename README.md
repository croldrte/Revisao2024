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