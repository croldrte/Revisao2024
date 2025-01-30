const produtos = [
    {
        breads: [
            {
                imagem: 'img/Pão Francês.jpg',
                nome: 'Pão Francês',
                preco: 1.50,
                medida: 'unidade',
                descricao: 'O tradicional pão francês, fresquinho, crocante por fora e macio por dentro.'
            },
            {
                imagem: 'img/Pão de Queijo.jpg',
                nome: 'Pão de Queijo',
                preco: 4.00,
                medida: 'unidade',
                descricao: 'Pão de queijo quentinho e irresistível, feito com queijo minas e polvilho.'
            },
            {
                imagem: 'img/Pão de Forma.jpg',
                nome: 'Pão de Forma',
                preco: 6.90,
                medida: 'fatia',
                descricao: 'Pão macio, ideal para sanduíches, disponível em versões integral e branco.'
            },
            {
                imagem: 'img/Pão Ciabatta.jpg',
                nome: 'Pão Ciabatta',
                preco: 7.00,
                medida: 'unidade',
                descricao: 'Pão italiano com crosta crocante e miolo aerado.'
            }
        ],
        savories: [
            {
                imagem: 'img/Coxinha de Frango.jpg',
                nome: 'Coxinha de Frango',
                preco: 6.00,
                medida: 'unidade',
                descricao: 'Massa crocante com recheio generoso de frango desfiado e temperado com carinho.'
            },
            {
                imagem: 'img/Empada de Palmito.jpg',
                nome: 'Empada de Palmito',
                preco: 5.50,
                medida: 'unidade',
                descricao: 'Massa amanteigada recheada com palmito refogado, uma verdadeira delícia.'
            },
            {
                imagem: 'img/Pastel de Queijo.jpg',
                nome: 'Pastel de Queijo',
                preco: 7.00,
                medida: 'unidade',
                descricao: 'Pastel de massa crocante, recheado com queijo muçarela derretido.'
            },
            {
                imagem: 'img/Esfiha de Carne.jpg',
                nome: 'Esfiha de Carne',
                preco: 4.50,
                medida: 'unidade',
                descricao: 'Massa leve e saborosa, recheada com carne temperada e cebola.'
            }
        ],
        sweets: [
            {
                imagem: 'img/Bolo de Cenoura com Chocolate.jpg',
                nome: 'Bolo de Cenoura com Chocolate',
                preco: 5.00,
                medida: 'fatia',
                descricao: 'Bolo fofinho de cenoura com cobertura cremosa de chocolate e granulado por cima.'
            },
            {
                imagem: 'img/Brigadeiro.jpg',
                nome: 'Brigadeiro',
                preco: 3.00,
                medida: 'unidade',
                descricao: 'O tradicional docinho de brigadeiro feito com leite condensado, chocolate e granulado.'
            },
            {
                imagem: 'img/Torta de Limão.jpg',
                nome: 'Torta de Limão',
                preco: 6.50,
                medida: 'fatia',
                descricao: 'Torta de base crocante, recheio cremoso de limão e cobertura de merengue.'
            },
            {
                imagem: 'img/Churros.jpg',
                nome: 'Churros',
                preco: 4.00,
                medida: 'unidade',
                descricao: 'Massa crocante com recheio de doce de leite, polvilhado com açúcar e canela.'
            }
        ],
        drinks: [
            {
                imagem: 'img/Café Expresso.jpg',
                nome: 'Café Expresso',
                preco: 3.00,
                medida: '50ml',
                descricao: 'Café forte e encorpado, ideal para acompanhar qualquer um de nossos pães.'
            },
            {
                imagem: 'img/Café com Leite.jpg',
                nome: 'Café com Leite',
                preco: 3.00,
                medida: '80ml',
                descricao: 'Café suave combinado com leite cremoso, ideal para um lanche da tarde.'
            },
            {
                imagem: 'img/Suco Natural.jpg',
                nome: 'Suco Natural',
                preco: 5.00,
                medida: '200ml',
                descricao: 'Suco feito com frutas selecionadas e espremido na hora. Opções: laranja, abacaxi, maracujá.'
            },
            {
                imagem: 'img/Chá Gelado.jpg',
                nome: 'Chá Gelado',
                preco: 4.50,
                medida: '200ml',
                descricao: 'Chá gelado refrescante, ideal para os dias quentes. Opções: pêssego, limão.'
            }
        ]
    }
];

function renderizarProdutos(categoria) {
    const container = document.getElementById(categoria);
    if (!container) return;

    let categorias = produtos[0];

    let produtosFiltrados = categoria === 'all'
        ? Object.values(categorias).flat()
        : categorias[categoria] || [];

    container.innerHTML = produtosFiltrados.length
        ? `<div class="row">` + produtosFiltrados.map(produto => `
            <div class="col-lg-6 px-5 pb-5">
                <div class="d-flex align-items-center">
                    <div class="flex-shrink-0">
                        <img src="${produto.imagem}" alt="${produto.nome}" width="150px">
                    </div>
                    <div class="flex-grow-1 ms-4">
                        <h5>${produto.nome}</h5>                        
                        <p">${produto.descricao}</p>
                        <p style="color: var(--butter)"><span style="font-weight: normal; font-size: 105%">R$ ${produto.preco.toFixed(2)}</span> <span style="font-size: 85%">(${produto.medida})</span></p>
                    </div>
                </div>
            </div>
        `).join("") + `</div>`
        : "<p class='text-center'>Nenhum produto disponível.</p>";
}

document.addEventListener("DOMContentLoaded", () => {
    renderizarProdutos("breads");
    renderizarProdutos("savories");
    renderizarProdutos("sweets");
    renderizarProdutos("drinks");
});