import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { Observable, Subject } from 'rxjs';
import { HttpErrorResponse } from '@angular/common/http';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  formulario: FormGroup;

  produtos: any[];
  produtosCosif: any[];

  camposDesabilidatos = false;

  listaMovimentacao: any[];

  constructor(
    private formBuilder: FormBuilder,
    private appService: AppService
  ) { }

  ngOnInit() {
    this.appService.obterProdutosAtivos().subscribe((data: any[]) => {
      console.log(data);
      this.produtos = data;
    });

    this.formulario = this.formBuilder.group({
      mes: ['', Validators.required],
      ano: ['', Validators.required],
      produto: ['', Validators.required],
      cosif: ['', Validators.required],
      valor: ['', Validators.required],
      descricao: ['', Validators.required],
    });

    this.desabilitarCampo();
    this.listar();

  }

  onSubmit() {

    const movimento = {
      'DAT_MES': this.formulario.get('mes').value,
      'DAT_ANO': this.formulario.get('ano').value,
      'COD_PRODUTO': this.formulario.get('produto').value,
      'COD_COSIF': this.formulario.get('cosif').value,
      'VAL_VALOR': this.formulario.get('valor').value,
      'DES_DESCRICAO': this.formulario.get('descricao').value
    };

    console.log('Movimento ', movimento);
    this.appService.adicionarMovimento(movimento).subscribe(
      (data: any) => {
        this.limparCampos();
        this.desabilitarCampo();
        this.listar();
      },
      (error: HttpErrorResponse) => {
        alert('ocorreu o seguinte erro ao cadastrar a movimentação: ' + error.message);
      }
    );
  }

  listar() {
    this.appService.lista().subscribe(
      (data: any) => {
        this.listaMovimentacao = data;
        console.log(data);
      }
    );
  }

  changeProduto($event) {
    const cod_produto = $event['value'];
    this.appService.obterProdutosCosif(cod_produto).subscribe((data: any) => {
      this.produtosCosif = data;
      console.log(data);
    });
  }

  limparCampos() {
    this.produtosCosif = null;
    this.formulario.reset();
  }

  novo() {
    this.formulario.controls['mes'].enable();
    this.formulario.controls['ano'].enable();
    this.formulario.controls['produto'].enable();
    this.formulario.controls['cosif'].enable();
    this.formulario.controls['valor'].enable();
    this.formulario.controls['descricao'].enable();
  }

  desabilitarCampo() {
    this.formulario.controls['mes'].disable();
    this.formulario.controls['ano'].disable();
    this.formulario.controls['produto'].disable();
    this.formulario.controls['cosif'].disable();
    this.formulario.controls['valor'].disable();
    this.formulario.controls['descricao'].disable();
  }

}
