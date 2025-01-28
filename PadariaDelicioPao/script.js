const produtos = [
    {
        id: 1,
        imagem: 'https://picsum.photos/500?random=1',
        nome: 'Pão Francês',
        tipo: 'Pães',
        preco: 1.50,
        descricao: 'O tradicional pão francês, fresquinho, crocante por fora e macio por dentro. Ideal para o café da manhã.'
    },
    {
        id: 2,
        imagem: 'https://picsum.photos/500?random=2',
        nome: 'Pão de Queijo',
        tipo: 'Pães',
        preco: 4.00,
        descricao: 'Pão de queijo quentinho e irresistível, feito com queijo minas e polvilho, perfeito para o café da manhã ou lanche da tarde.'
    }
];

divProduto.innerHTML = `
<div class="d-flex align-items-center mb-4">
    <div class="flex-shrink-0">
        <img src="${produto.imagem}" alt="..." width="150px">
    </div>
    <div class="flex-grow-1 ms-3">
        <h5>${produto.nome}</h5>
        <p>${produto.descricao}</p>
    </div>
</div>
`;