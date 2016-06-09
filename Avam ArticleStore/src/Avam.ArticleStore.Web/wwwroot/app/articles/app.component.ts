import {Component} from 'angular2/core';
import 'rxjs/Rx';
import {ArticleListComponent} from './article-list.component';
import {ArticleAddEditComponent} from './article-edit.component';

import {ROUTER_PROVIDERS, RouteConfig, ROUTER_DIRECTIVES} from 'angular2/router';
import {HTTP_PROVIDERS} from 'angular2/http';
import {ArticleService} from './article.service';


@Component({
    selector: 'avam-articles',
    templateUrl: 'app/articles/app.component.html',
    //styleUrls: ['app/articles/app.component.css'],
    providers: [ROUTER_PROVIDERS, HTTP_PROVIDERS,ArticleService],
    directives: [ROUTER_DIRECTIVES],
})
@RouteConfig([
    {path: '/', name:'Articles', component: ArticleListComponent, useAsDefault:true},
    {path: '/articles', name:'Articles', component: ArticleListComponent},
    {path: '/articles/addedit/:id', name:'EditNewArticle', component: ArticleAddEditComponent}
])
export class ArticleAppComponent{
    
}
