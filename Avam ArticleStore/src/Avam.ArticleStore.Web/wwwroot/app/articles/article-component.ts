import {Component, Input} from 'angular2/core';
import {IArticle} from './article';
import {ROUTER_DIRECTIVES} from 'angular2/router';

@Component({
    selector: 'avam-article',
    templateUrl:'app/articles/article-component.html',
    directives: [ROUTER_DIRECTIVES]
})
export class ArticleComponent{
    @Input() article: IArticle;
    
}