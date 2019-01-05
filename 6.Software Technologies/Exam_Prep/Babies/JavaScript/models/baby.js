const Sequelize = require('sequelize');

module.exports = function (sequelize) {
    const Baby = sequelize.define('Baby', {
        name: {
            type:Sequelize.TEXT,
            required:true,
            allowNull:false
        },
        gender: {
            type:Sequelize.TEXT,
            required:true,
            allowNull:false
        },
        birthday:{
            type:Sequelize.TEXT,
            required:true,
            allowNull:false
        }
    },{
        timestamps:false
    });

    return Baby;
};