import {Component, OnInit} from 'angular2/core';
import {ArticleComponent} from './article-component';
import {IArticle} from './article';
import {ArticleService} from './article.service';
import {ROUTER_DIRECTIVES} from 'angular2/router';

@Component({
    selector: 'article-list',
    templateUrl: 'app/articles/article-list.component.html',
    styleUrls: ['app/articles/app.component.css'],
    directives:[ArticleComponent,ROUTER_DIRECTIVES]
})
export class ArticleListComponent implements OnInit{
    articles: IArticle[];
    error:string;
    
    constructor(private articleSvc: ArticleService){
    }
    
    ngOnInit():void{
        this.articleSvc.getArticles()
            .subscribe(
                articles=> this.articles=articles,
                error=>this.error = error);
    }
}