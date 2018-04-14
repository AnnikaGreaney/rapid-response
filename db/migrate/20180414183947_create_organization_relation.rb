class CreateOrganizationRelation < ActiveRecord::Migration
  def change
    create_table :organization_relations do |t|
      t.references :organization
      t.references :works_with_organization, references: :organization
    end
  end
end
