System.register(['angular2/core', 'rxjs/Rx', './article-list.component', './article-edit.component', 'angular2/router', 'angular2/http', './article.service'], function(exports_1, context_1) {
    "use strict";
    var __moduleName = context_1 && context_1.id;
    var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
        var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
        if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
        else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
        return c > 3 && r && Object.defineProperty(target, key, r), r;
    };
    var __metadata = (this && this.__metadata) || function (k, v) {
        if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
    };
    var core_1, article_list_component_1, article_edit_component_1, router_1, http_1, article_service_1;
    var ArticleAppComponent;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (_1) {},
            function (article_list_component_1_1) {
                article_list_component_1 = article_list_component_1_1;
            },
            function (article_edit_component_1_1) {
                article_edit_component_1 = article_edit_component_1_1;
            },
            function (router_1_1) {
                router_1 = router_1_1;
            },
            function (http_1_1) {
                http_1 = http_1_1;
            },
            function (article_service_1_1) {
                article_service_1 = article_service_1_1;
            }],
        execute: function() {
            ArticleAppComponent = (function () {
                function ArticleAppComponent() {
                }
                ArticleAppComponent = __decorate([
                    core_1.Component({
                        selector: 'avam-articles',
                        templateUrl: 'app/articles/app.component.html',
                        //styleUrls: ['app/articles/app.component.css'],
                        providers: [router_1.ROUTER_PROVIDERS, http_1.HTTP_PROVIDERS, article_service_1.ArticleService],
                        directives: [router_1.ROUTER_DIRECTIVES],
                    }),
                    router_1.RouteConfig([
                        { path: '/', name: 'Articles', component: article_list_component_1.ArticleListComponent, useAsDefault: true },
                        { path: '/articles', name: 'Articles', component: article_list_component_1.ArticleListComponent },
                        { path: '/articles/addedit/:id', name: 'EditNewArticle', component: article_edit_component_1.ArticleAddEditComponent }
                    ]), 
                    __metadata('design:paramtypes', [])
                ], ArticleAppComponent);
                return ArticleAppComponent;
            }());
            exports_1("ArticleAppComponent", ArticleAppComponent);
        }
    }
});
//# sourceMappingURL=app.component.js.map