const Article= require('../models').Article;

module.exports =  {
    createGet: (req, res) => {
      res.render('article/create');
    },

    createPost: (req, res)=> {
        let articleArgs = req.body;
        let errorMsg = '';

        if(!req.isAuthenticated()) {
            errorMsg = 'You should be logged in to make articles!';
        } else if (!articleArgs.title){
            errorMsg = 'Invalid title!';
        }else if (!articleArgs.content) {
            errorMsg = 'Invalid content!';
        }

        if(errorMsg){
           return res.render('article/create', {error: errorMsg});
        }

        articleArgs.authorId = req.user.id;

        Article.create(articleArgs).then(()=> {
            res.redirect('/');
        }).catch(err=> {
            console.log(err.message);
            res.render('article/create', {error: err.message})
        });
    },

    details:(req, res) => {
        let articleId = req.params.id;
        Article.findById( articleId)
            .then(article=> {
                res.render('article/details', article.dataValues);

            })

    }
};