import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable()
export  class AppService {

  constructor(
    private http: HttpClient
  ) { }

    obterProdutosAtivos() {
      return this.http.get(environment.urlWebApi + '/api/produto/consultarProdutosAtivos');
    }

    obterProdutosCosif(COD_PRODUTO: any) {
      return this.http.get(environment.urlWebApi + '/api/produtoCosif/consultarPorProduto/' + COD_PRODUTO);
    }

    adicionarMovimento(movimento: any) {
      return this.http.post(environment.urlWebApi + '/api/movimentoManual/adicionar', movimento);
    }

    lista() {
      return this.http.get(environment.urlWebApi + '/api/movimentoManual/lista');
    }

}
