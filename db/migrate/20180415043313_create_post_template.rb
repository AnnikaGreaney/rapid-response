class CreatePostTemplate < ActiveRecord::Migration
  def change
    create_table :post_templates do |t|
      t.string :template_name
      t.text :content
    end
  end
end
