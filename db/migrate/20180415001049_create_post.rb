class CreatePost < ActiveRecord::Migration
  def change
    create_table :posts do |t|
      t.string :template_name
      t.text :content
    end
  end
end
