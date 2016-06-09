import {Component, OnInit} from 'angular2/core';
import {NgForm, NgClass} from 'angular2/common';
import {IArticle, ITag} from './article';
import {ArticleService} from './article.service';
import {RouteParams, Router} from 'angular2/router';

@Component({
    templateUrl: 'app/articles/article-edit.component.html',
    styleUrls: ['app/articles/app.component.css'],
    directives: [NgClass]
})
export class ArticleAddEditComponent implements OnInit{
    article: IArticle ;
    errorMessage: string;
    pageTitle: string = "Loading...";
    isNew : boolean;
    tags: ITag[];
    
    constructor(private _articleSvc: ArticleService, 
                private _routeParams: RouteParams,
                private _router: Router){
                    this.article=_articleSvc.getEmptyArticle();
    }
    
    ngOnInit(): void{
        this._articleSvc.getTags()
            .subscribe(
                t=>this.tags=t,
                error=>this.errorMessage=<any>error
            );
        let id : string = this._routeParams.get('id');
        this.isNew = parseInt(id) <= 0;
        if(!this.isNew){
            this._articleSvc.getArticle(id)
                .subscribe(
                    rtcl=>this.onArticleLoaded(rtcl),
                    error=>this.errorMessage=<any>error
                );
        } else {
            this.pageTitle = "New Article";
        }
    }
    private onArticleLoaded(article: IArticle):void{
        this.article=article;
        this.pageTitle = article.title + " [Edit]";
    }
    OnBack(): void{
        this._router.navigate(['Articles']);
    }
    onSave():void{
        console.log(this.article);
        this._articleSvc.saveArticle(this.article)
            .subscribe(
                art=> this.article=art,
                err=> this.errorMessage=<any>err
            );
    }
}