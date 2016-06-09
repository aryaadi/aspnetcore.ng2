System.register(['angular2/core', 'angular2/http', 'rxjs/Observable'], function(exports_1, context_1) {
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
    var core_1, http_1, Observable_1;
    var ArticleService;
    return {
        setters:[
            function (core_1_1) {
                core_1 = core_1_1;
            },
            function (http_1_1) {
                http_1 = http_1_1;
            },
            function (Observable_1_1) {
                Observable_1 = Observable_1_1;
            }],
        execute: function() {
            ArticleService = (function () {
                function ArticleService(_http) {
                    this._http = _http;
                    //private dataUrl : string = '/data/articles.json';
                    this.dataUrl = '/api/articles';
                }
                ArticleService.prototype.getEmptyArticle = function () {
                    return {
                        id: 0,
                        title: '',
                        primaryTag: '',
                        //secondaryTags: '',
                        description: '',
                        briefBody: '',
                        addedOn: new Date(1900, 1, 1),
                        publishDate: new Date(1900, 1, 1),
                        sourceUrl: '',
                        author: ''
                    };
                };
                ArticleService.prototype.getArticle = function (id) {
                    var a = this.getArticles().map(function (articles) {
                        return articles.find(function (article) { return article.id == id; });
                    });
                    return a;
                };
                ArticleService.prototype.getArticles = function () {
                    return this._http.get(this.dataUrl)
                        .map(function (response) { return response.json(); })
                        .catch(this.handleError);
                };
                ArticleService.prototype.getTags = function () {
                    return this._http.get('/api/tags')
                        .map(function (response) { return response.json(); })
                        .catch(this.handleError);
                };
                ArticleService.prototype.saveArticle = function (article) {
                    return this._http.post(this.dataUrl + '/save', JSON.stringify(article))
                        .map(function (response) { return response.json(); })
                        .catch(this.handleError);
                    ;
                };
                ArticleService.prototype.handleError = function (error) {
                    console.error(error);
                    return Observable_1.Observable.throw(error.json().error || 'server error');
                };
                ArticleService = __decorate([
                    core_1.Injectable(), 
                    __metadata('design:paramtypes', [http_1.Http])
                ], ArticleService);
                return ArticleService;
            }());
            exports_1("ArticleService", ArticleService);
        }
    }
});
//# sourceMappingURL=article.service.js.map