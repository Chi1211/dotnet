using System;

namespace Entity_2{
    public class CategoryDetail{
        public int CategoryDetailID{get; set;}
        public int UseId{get; set;}

        public DateTime Created{get; set;}
        public DateTime Updated{get;set;}
        public CategoryModel categoryModel{get; set;}
    }
}